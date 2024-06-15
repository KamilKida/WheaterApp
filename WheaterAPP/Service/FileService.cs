using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WheaterAPP.Models;


namespace WheaterAPP.Service
{
    public class FileService
    {
        /// <summary>
        /// Serializuje obiekt reprezentujący informacje o pogodzie do pliku json.
        /// </summary>
        /// <param name="infoToSerialize">Objekt do serializzacji.</param>
        /// <returns>Czy operacja się powiodła.</returns>
        public bool SerializeToJson(WheaterInfoModel.root infoToSerialize)
        {
            try
            {
                string historyFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Params.historyDirectoryName);

                if (!Directory.Exists(historyFolderPath))
                {
                    Directory.CreateDirectory(historyFolderPath);
                }

                string filePath = $"{historyFolderPath}\\{infoToSerialize.name}_{(DateTime.Now).ToString("dd-MM-yyyy")}_{DateTime.Now.ToString("mm-HH")}.json";

                infoToSerialize.dateOfCreation  = DateTime.Now;

                string jsonSting = JsonConvert.SerializeObject(infoToSerialize);

                File.WriteAllText(filePath, jsonSting);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś pooszło nie tak podczas próby zapisania informacji o pogodzie.");

                return false;
            }
        }

        /// <summary>
        /// Pobiera listę plików z zapisanymi prognozami pogody. 
        /// </summary>
        /// <returns>Lista plików.</returns>
        public List<string> GetHistoryFilesList()
        {
            List<string> filesList = new List<string>();

            string historyFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Params.historyDirectoryName);

            if (Directory.Exists(historyFolderPath))
            {
                string[] files = Directory.GetFiles(historyFolderPath);

                filesList.AddRange(files);
            }

            return filesList;
        }

        /// <summary>
        /// Tworzy listę obiektów na podstawie listy plików reprezentujących zapisane informacje o pogodzie. 
        /// </summary>
        /// <param name="jsonFiles">Lista plików do deserializacji.</param>
        /// <returns>Liste objektów reprezentujących zapisane informacje o pogodzie.</returns>
        public List<WheaterInfoModel.root> HistoryList(List<string> jsonFiles)
        {
            List<WheaterInfoModel.root> deserializedHistory = new List<WheaterInfoModel.root>();

            foreach(var file in jsonFiles)
            {
                try
                {
                    string jsonContent = File.ReadAllText(file);

                    var newObject = JsonConvert.DeserializeObject<WheaterInfoModel.root>(jsonContent);

                    deserializedHistory.Add(newObject);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            return deserializedHistory;
           
        }

        /// <summary>
        /// Nadpisuje istniejący plik json.
        /// </summary>
        /// <param name="filePathToOverwrite">Ścieżkę do pliku, który chce się nadpisać.</param>
        /// <param name="infoToSerialize">Czym nadpisać plik.</param>
        public void OverWriteFile(string filePathToOverwrite, WheaterInfoModel.root infoToSerialize)
        {
            infoToSerialize.dateOfCreation = DateTime.Now;

            string newJsonContent = JsonConvert.SerializeObject(infoToSerialize);

            File.WriteAllText(filePathToOverwrite, newJsonContent);
        }
    }
}

          