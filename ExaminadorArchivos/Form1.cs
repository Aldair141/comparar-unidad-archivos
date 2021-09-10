using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExaminadorArchivos
{
    public partial class Form1 : Form
    {
        string[] rutasA, rutasB;
        FileSystemWatcher watcherA = null;
        FileSystemWatcher watcherB = null;

        enum OpcionRuta
        {
            RutaA = 1,
            RutaB = 2
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            if (fbdEstablecerRuta.ShowDialog() == DialogResult.OK)
            {
                string ruta = fbdEstablecerRuta.SelectedPath;
                if (ruta != "")
                {
                    try
                    {
                        rutasA = BuscarArchivos(ruta);
                        ListarArchivosEncontrados(rutasA, lstArchivosA);
                        GenerarEventosEscucha(OpcionRuta.RutaA, ruta);
                        txtRutaA.Text = ruta;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtRutaA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ruta = txtRutaA.Text;
                if (ruta.Length > 0)
                {
                    try
                    {
                        rutasA = BuscarArchivos(ruta);
                        ListarArchivosEncontrados(rutasA, lstArchivosA);
                        GenerarEventosEscucha(OpcionRuta.RutaA, ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscarB_Click(object sender, EventArgs e)
        {
            if (fbdEstablecerRuta.ShowDialog() == DialogResult.OK)
            {
                string ruta = fbdEstablecerRuta.SelectedPath;
                if (ruta != "")
                {
                    try
                    {
                        rutasB = BuscarArchivos(ruta);
                        ListarArchivosEncontrados(rutasB, lstArchivosB);
                        GenerarEventosEscucha(OpcionRuta.RutaB, ruta);
                        txtRutaB.Text = ruta;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string[] BuscarArchivos(string ruta)
        {
            try
            {
                return Directory.GetFiles(ruta, "*.pdf", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtRutaB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ruta = txtRutaB.Text;
                if (ruta.Length > 0)
                {
                    try
                    {
                        rutasB = BuscarArchivos(ruta);
                        ListarArchivosEncontrados(rutasB, lstArchivosB);
                        GenerarEventosEscucha(OpcionRuta.RutaB, ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            string nombreArchivo = "";
            foreach (string rutaA in rutasA)
            {
                nombreArchivo = Path.GetFileName(rutaA);
                if (!EncontrarArchivoEnDestino(nombreArchivo))
                {
                    lstResultado.Items.Add(nombreArchivo);
                }
            }
        }

        private void ListarArchivosEncontrados(string[] rutas, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (string ruta in rutas)
            {
                listbox.Items.Add(Path.GetFileName(ruta));
            }
            var controlParent = listbox.Parent;
            Label control = controlParent.Controls.OfType<Label>().FirstOrDefault();
            control.Text = "Documentos encontrados: " + rutas.Length;
        }

        private int RetornarIndiceArchivo(string ruta, string[] rutas)
        {
            int item = -1;
            for (int i = 0; i < rutas.Length; i++)
            {
                if (ruta == rutas[i])
                {
                    item = i;
                    break;
                }
            }
            return item;
        }

        private bool EncontrarArchivoEnDestino(string nombreArchivo)
        {
            bool encontro = false;
            string archivoB;
            foreach (string rutaB in rutasB)
            {
                archivoB = Path.GetFileName(rutaB);
                if (nombreArchivo == archivoB)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        private void GenerarEventosEscucha(OpcionRuta opcionRuta, string ruta)
        {
            if (opcionRuta == OpcionRuta.RutaA)
            {
                watcherA = new FileSystemWatcher(ruta);
                watcherA.IncludeSubdirectories = true;
                watcherA.NotifyFilter = NotifyFilters.Attributes |
                                       NotifyFilters.CreationTime |
                                       NotifyFilters.DirectoryName |
                                       NotifyFilters.FileName |
                                       NotifyFilters.LastWrite |
                                       NotifyFilters.LastAccess |
                                       NotifyFilters.Security;
                watcherA.Filter = "*.pdf";
                //watcherA.Changed += new FileSystemEventHandler(listenerActualizarA);
                watcherA.Created += new FileSystemEventHandler(listenerAdicionarA);
                watcherA.Deleted += new FileSystemEventHandler(listenerBorrarA);
                watcherA.Renamed += new RenamedEventHandler(listenerRenombrarA);
                watcherA.EnableRaisingEvents = true;
            }
            else
            {
                watcherB = new FileSystemWatcher(ruta);
                watcherB.IncludeSubdirectories = true;
                watcherB.NotifyFilter = NotifyFilters.Attributes |
                                       NotifyFilters.CreationTime |
                                       NotifyFilters.DirectoryName |
                                       NotifyFilters.FileName |
                                       NotifyFilters.LastWrite |
                                       NotifyFilters.LastAccess |
                                       NotifyFilters.Security;
                watcherB.Filter = "*.pdf";
                watcherB.Changed += new FileSystemEventHandler(listenerB);
                watcherB.Created += new FileSystemEventHandler(listenerB);
                watcherB.Deleted += new FileSystemEventHandler(listenerB);
                watcherB.Renamed += new RenamedEventHandler(renamedB);
                watcherB.EnableRaisingEvents = true;
            }
        }

        #region Eventos
        public void listenerBorrarA(object source, FileSystemEventArgs e)
        {
            string rutaArchivo = e.FullPath;
            int item = RetornarIndiceArchivo(rutaArchivo, rutasA);
            rutasA = rutasA.Where(x => x != rutaArchivo).ToArray();
            lstArchivosA.Invoke(new Action(() => lstArchivosA.Items.RemoveAt(item)));
            lblArchivosEncontradosA.Invoke(new Action(() => lblArchivosEncontradosA.Text = "Documentos encontrados: " + rutasA.Length));
        }

        public void listenerAdicionarA(object source, FileSystemEventArgs e)
        {
            string rutaArchivo = e.FullPath;
            List<string> tempList = rutasA.ToList();
            tempList.Add(rutaArchivo);
            rutasA = tempList.ToArray();
            lstArchivosA.Invoke(new Action(() => lstArchivosA.Items.Add(Path.GetFileName(rutaArchivo))));
            lblArchivosEncontradosA.Invoke(new Action(() => lblArchivosEncontradosA.Text = "Documentos encontrados: " + rutasA.Length));
        }

        public void listenerRenombrarA(object source, RenamedEventArgs e)
        {
            string rutaArchivoAnterior = e.OldFullPath;
            string rutaArchivoActual = e.FullPath;
            int item = RetornarIndiceArchivo(rutaArchivoAnterior, rutasA);
            if (item >= 0)
            {
                rutasA[item] = rutaArchivoActual;
                lstArchivosA.Invoke(new Action(() => lstArchivosA.Items[item] = Path.GetFileName(rutaArchivoActual)));
            }
        }

        public void listenerB(object source, FileSystemEventArgs e)
        {
            string rutaArchivo = e.FullPath;
            int item = RetornarIndiceArchivo(rutaArchivo, rutasB);
            rutasB = rutasB.Where(x => x != rutaArchivo).ToArray();
            lstArchivosB.Invoke(new Action(() => lstArchivosB.Items.RemoveAt(item)));
        }

        public void renamedB(object source, RenamedEventArgs e)
        {
            MessageBox.Show("Acción detectada");
        }
        #endregion
    }
}