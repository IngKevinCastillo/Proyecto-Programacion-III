using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioGastos : RepositorioPrincipal<Entity.Gasto>
    {
        public RepositorioGastos(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override Gasto buscarDato(int id)
        {
            List<Gasto> gastos = cargarDatos();
            Gasto gastoConsultado = gastos.Find(gastoAConsultar => gastoAConsultar.IdGasto == id);
            return gastoConsultado;
        }

        public override List<Gasto> cargarDatos()
        {
            try
            {
                List<Entity.Gasto> gastos = new List<Entity.Gasto>();
                string linea;
                StreamReader lector = new StreamReader(_nombreArchivo);
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    gastos.Add(Mapeo(linea));
                }
                lector.Close();
                return gastos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostra los datos. El error esta en: {ex.Message}");
                return null;
            }
        }

        public Gasto ConsultarDatoFecha(DateTime fechaConsulta)
        {
            List<Gasto> gastos = cargarDatos();
            Gasto gastoConsultado = gastos.Find(gastoAConsultar => gastoAConsultar.FechaGasto.ToString("dd-MM-yyyy") == fechaConsulta.ToString("dd-MM-yyyy"));
            return gastoConsultado;
        }

        public override void eliminarDatos(int id)
        {
            try
            {
                List<Gasto> gastos = cargarDatos();
                gastos.RemoveAll(gastoAEliminar => gastoAEliminar.IdGasto == id);
                using (StreamWriter escritor = new StreamWriter(_nombreArchivo, false))
                {
                    foreach (Gasto ListaGastoNueva in gastos)
                    {
                        escritor.WriteLine(ListaGastoNueva.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar un dato. El error esta en: {ex.ToString()}");
            }
        }
        public override List<Gasto> obtenerDatos()
        {
            List<Entity.Gasto> gastos = null;
            gastos = cargarDatos();
            return gastos;
        }

        private Gasto Mapeo(string linea)
        {
            Gasto gasto = new Gasto();
            gasto.IdGasto = int.Parse(linea.Split(';')[0]);
            gasto.DescripcionGasto = linea.Split(';')[1];
            gasto.PrioridadGasto = linea.Split(';')[2];
            gasto.Categoria = linea.Split(';')[3];
            gasto.FechaGasto = DateTime.Parse(linea.Split(';')[4]);
            gasto.Monto = double.Parse(linea.Split(';')[5]);
            return gasto;
        }
    }
}
