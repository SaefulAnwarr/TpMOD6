using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul6_kelompok_2 
{ 
    class Program 
    {
        static void Main(String[] args) 
        {
            DataMahasiswa objMhs= new DataMahasiswa("Saeful", "anwar", 1302204065, "SE-44-01");
            //String readJson = File.ReadAllText(@"data.json");
            TulisJsonFile(objMhs);
        }

        static void TulisJsonFile(DataMahasiswa input) 
        {
            string json = JsonConvert.SerializeObject(input);
            Console.WriteLine(jsonString);

            File.WriteAllText(D:\Tugas Kuliah\Semester IV\Konstruksi PL\Praktikum_kpl\TP\tpMod6\tpmodul6_kelompok_2 1302204065.json);
        }
    }
}