using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Lote
    {
        int numero;
        double[]medidas;
        int cantidad;
        public Lote()
        {
        }

        public double VerMedida(int idx)
        {
            
            return medidas[idx];
        }
        public void RegistrarMedida (double medida)
        {
            medidas[cantidad] = medida;
            cantidad++;
        }
        public double VerCantidad (int cantidad)
        {
            return cantidad;
        }

        public double 
    }
}
