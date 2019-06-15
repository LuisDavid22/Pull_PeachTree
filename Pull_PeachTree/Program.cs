using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Pull_PeachTree
{
    class Program
    {
        static void Main(string[] args)
        {
            peachTreeDBEntities db = new peachTreeDBEntities();
            StreamReader archivo = new StreamReader("layout_madedera.txt");

            string json = archivo.ReadToEnd();

            ClaseEsquema clase = JsonConvert.DeserializeObject<ClaseEsquema>(json);


            Asiento cabecera = new Asiento
            {
                numeroAsiento = clase.numeroAsiento,
                detalleAsiento = clase.detalleAsiento,
                fecha = Convert.ToDateTime(clase.Fecha),
                totalDebito = Convert.ToDecimal(clase.totalDebito),
                totalCredito= Convert.ToDecimal(clase.totalCredito),
                Asiento_Detalle = clase.cuentas

            };

            if (cabecera != null)
            {
                db.Asiento.Add(cabecera);
                db.SaveChanges();
            }
            
        }
    
        
    }
    class ClaseEsquema
    {
        public int numeroAsiento { get; set; }
        public string detalleAsiento { get; set; }
        public DateTime Fecha { get; set; }
        public double totalDebito { get; set; }
        public double totalCredito { get; set; }
        public ICollection<Asiento_Detalle> cuentas { get; set; }
    }
}
