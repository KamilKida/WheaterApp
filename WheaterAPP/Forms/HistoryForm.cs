using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WheaterAPP.Models;
using WheaterAPP.Service;

namespace WheaterAPP.Forms
{
    public partial class HistoryForm : Form
    {
        private FileService fileService;
        public HistoryForm(List<WheaterInfoModel.root> historyList) : this()
        {
            bS_History.DataSource = historyList;
            fileService = new FileService();
        }
        public HistoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pozwala na wyświetlenie lub usunięcie danego historycznego wpisu o pogodzie.  
        /// </summary>
        private void dGV_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_History.Columns[e.ColumnIndex].Name == "Show")
            {
                WheaterInfoModel.root focusedHistory = (WheaterInfoModel.root)bS_History.Current;

                var showHistoryInfo = new ShowHistoryForm(focusedHistory);

                showHistoryInfo.ShowDialog();
            }
            else if (dGV_History.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult deleteaResult = MessageBox.Show("Czy na pewno chcesz usunąć tę historie pogody?", "Wybów", MessageBoxButtons.YesNo);

                if (deleteaResult == DialogResult.Yes)
                {
                    try
                    {
                        WheaterInfoModel.root focusedHistory = (WheaterInfoModel.root)bS_History.Current;

                        var fileList = fileService.GetHistoryFilesList();

                        var fileToDelete = fileList.Where(x => Path.GetFileName(x)
                                                   .Contains(focusedHistory.name)
                                                   && Path.GetFileName(x)
                                                   .Contains(focusedHistory.dateOfCreation.ToString("dd-MM-yyyy")))
                                                   .FirstOrDefault();

                        File.Delete(fileToDelete);

                        bS_History.RemoveCurrent();

                        MessageBox.Show("Historia pogody została usunięta.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie udało się usunąć histori pogody.");
                    }
                }
                else
                {
                    MessageBox.Show("Historia pogody nie została usunięta.");
                }
            }
        }
    }
}
                  
