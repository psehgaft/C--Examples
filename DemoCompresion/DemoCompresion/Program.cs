using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace DemoCompresion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un FileInfo : Obtiene toda la info. asociada a un archivo
            FileInfo fi = new FileInfo("../Hola.doc");
            //2. Crear un FileStream mediante el metodo Open() del FileInfo
            FileStream fs = fi.Open(FileMode.Open);
            //3. Obtener tamaño en bytes del archivo
            int TAM = (int)fi.Length;

            //4. Crear un FileStream para mandar el archivo comprimido
            FileStream fsEsc = new FileStream("../../Program.compress", FileMode.Create);
            //5. Crear un DeflateStream
            DeflateStream ds = new DeflateStream(fsEsc, CompressionMode.Compress);
            //6. Crear el arreglo a comprimir (leyendo el archivo origen)
            byte[] bytes = new byte[TAM];
            fs.Read(bytes, 0, TAM);
            fs.Close();
            //7.Escribir el archivo comprimido
            ds.Write(bytes, 0, TAM);
            //8. Cerrar el flujo de datos
            ds.Close();
            fsEsc.Close();

            Console.WriteLine("Archivo comprimido...\n");
            Console.ReadLine();
        }
    }
}
