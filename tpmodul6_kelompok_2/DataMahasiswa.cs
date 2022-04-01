using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul6_kelompok_2
{
    class DataMahasiswa
    {
        void ReadJson()
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText("D:\Tugas Kuliah\Semester IV\Konstruksi PL\Praktikum_kpl\TP\tpMod6\tpmodul6_kelompok_2 1302204065.json");
            //Deserialize file json menjadi object
            ContohClassDataMahasiswa DataMahasiswa =
            JsonSerializer.Deserialize<ContohClassDataMahasiswa>(jsonString);
            Console.WriteLine("Nama Depan :" + DataMahasiswa.nama);
            Console.WriteLine("Nama Belakang :" + DataMahasiswa.nama)
            Console.WriteLine("NIM :" + DataMahasiswa.nim);
            Console.WriteLine("Fakultas :" + DataMahasiswa.fakultas);

            
        }
    }
}

