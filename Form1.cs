using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        private void UpdatingEvent()
        {
            //dgvEvents
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = EventDBO.ShowAll();
            dgvEvents.Columns[0].Width = 60;
            dgvEvents.Columns[1].Width = 160;
            dgvEvents.Columns[2].Width = 64;
            dgvEvents.Columns[3].Width = 400;
            dgvEvents.Columns[4].Width = 100;
            dgvEvents.Columns[5].Width = 100;
            dgvEvents.Columns[6].Width = 80;
            dgvEvents.Columns[7].Width = 150;
            dgvEvents.RowTemplate.Height = 64;
 
            //cmbEventArea
            cmbEventArea.DataSource = null;
            cmbEventArea.ValueMember = "AreaID";
            cmbEventArea.DisplayMember = "Area";
            cmbEventArea.DataSource = EventDBO.ShowArea();

            //numSelectEventID
            int id = Convert.ToInt32(numEventID.Value);
            string returnValue = EventDBO.FilterEvent(id);
            if (returnValue.Length != 0)
            {
                lblEventState.Visible = true;
                btnAddNewEvent.Enabled = false;
                lblEventState.Text = "El registro ya existe!";
                btnEditEvent.Enabled = true;
                btnEliminarRegistro.Enabled = true;
            }
            else
            {
                btnAddNewEvent.Enabled = true;
                lblEventState.Visible = false;
                btnEliminarRegistro.Enabled = false;
                btnEditEvent.Enabled = false;
            }
            picEventImage.Image = null;
            numEventAssistants.ResetText();
            txtEventDescription.Clear();
            txtEventName.Clear();
        }
        private void UpdatingCollection()
        {
            //dgvColeccions
            dgvCollections.DataSource = null;
            dgvCollections.DataSource = CollectionDBO.ShowAll();

            //cmb Tipo
            cmbTypes.DataSource = null;
            cmbTypes.ValueMember = "TipoID";
            cmbTypes.DisplayMember = "Tipo";
            cmbTypes.DataSource = CollectionDBO.ShowTypes();

            //cmb Tipo
            cmbGender.DataSource = null;
            cmbGender.ValueMember = "GeneroID";
            cmbGender.DisplayMember = "Genero";
            cmbGender.DataSource = CollectionDBO.ShowGenders();


            //numSelectEventID
            int id = Convert.ToInt32(numCollectionID.Value);
            string returnValue = CollectionDBO.FilterCollection(id);
            if (returnValue.Length > 0)
            {
                lblCollectionStatus.Visible = true;
                btnAddNewCollection.Enabled = false;
                lblCollectionStatus.Text = "El registro ya existe!";
                btnUpdateCollection.Enabled = true;
                btnDeleteCollection.Enabled = true;
            }
            else
            {
                btnAddNewCollection.Enabled = true;
                lblCollectionStatus.Visible = false;
                btnDeleteCollection.Enabled = false;
                btnUpdateCollection.Enabled = false;
            }
        }
        private void UpdatingUser()
        {
            string returnValue = UserDBO.FilterUser(Convert.ToInt32(numUserID.Value));
            int id = Convert.ToInt32(numUserID.Value);
            dgvAllUsers.DataSource = null;
            dgvAllUsers.DataSource = UserDBO.ShowAll();
            if(returnValue.Length == 0)
            {
                btnAddUser.Enabled = true;
                btnUpdateUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
            else
            {
                btnAddUser.Enabled = false;
                btnUpdateUser.Enabled = true;
                btnDeleteUser.Enabled = true;

            }

        }

        private void UpdatingBook()
        {
            string returnValue = "";
            returnValue = BookDBO.Filter(Convert.ToInt32(numEjID.Value));
            this.eJEMPLARTableAdapter.Fill(this.databankPOObjDataSet1.EJEMPLAR);

            if (returnValue.Length == 0)
            {
                btnNewEj.Enabled = true;
                btnUpdateEj.Enabled = false;
                btnDeleteEj.Enabled = false;
            }
            else
            {
                btnNewEj.Enabled = false;
                btnUpdateEj.Enabled = true;
                btnDeleteEj.Enabled = true;

            }


            

        }
        private void btnSelectEventImage_Click(object sender, EventArgs e)
        {
            ofdSelectEventImage.Filter = "Imagenes|*.jpg; *.png";
            ofdSelectEventImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSelectEventImage.Title = "Seleccionar Imagen";
            if (ofdSelectEventImage.ShowDialog() == DialogResult.OK)
            {
                picEventImage.Image = Image.FromFile(ofdSelectEventImage.FileName);
            }
        }

        private void coleccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatingEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databankPOObjDataSet4.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter1.Fill(this.databankPOObjDataSet4.USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'databankPOObjDataSet3.PRESTAMOXEJEMPLAR' Puede moverla o quitarla según sea necesario.
            this.pRESTAMOXEJEMPLARTableAdapter.Fill(this.databankPOObjDataSet3.PRESTAMOXEJEMPLAR);
            // TODO: esta línea de código carga datos en la tabla 'databankPOObjDataSet2.RESERVAXEJEMPLAR' Puede moverla o quitarla según sea necesario.
            this.rESERVAXEJEMPLARTableAdapter.Fill(this.databankPOObjDataSet2.RESERVAXEJEMPLAR);
            // TODO: esta línea de código carga datos en la tabla 'databankPOObjDataSet1.EJEMPLAR' Puede moverla o quitarla según sea necesario.
            this.eJEMPLARTableAdapter.Fill(this.databankPOObjDataSet1.EJEMPLAR);
            // TODO: esta línea de código carga datos en la tabla 'databankPOObjDataSet.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.databankPOObjDataSet.USUARIO);

            UpdatingEvent();
            UpdatingCollection();
            UpdatingUser();
            UpdatingBook();
        }

        private void numEventID_ValueChanged(object sender, EventArgs e)
        {
            UpdatingEvent();
        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            if (txtEventName.Text.Length != 0 && txtEventDescription.Text.Length != 0)
            {
                if (picEventImage.Image is null)
                {
                    MessageBox.Show("Agrega una imagen!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpEventEnds.Value <= dtpEventStart.Value)
                {
                    MessageBox.Show("Verifica las fechas!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numEventAssistants.Value <= 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida en el campo 'Asistentes'!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EventDatabase EventToAdd = new EventDatabase();
                    EventToAdd.EventoID = Convert.ToInt32(numEventID.Value);
                    EventToAdd.Titulo = txtEventName.Text;
                    EventToAdd.Objetivo = txtEventDescription.Text;
                    MemoryStream msEvent = new MemoryStream();
                    picEventImage.Image.Save(msEvent, ImageFormat.Bmp);
                    EventToAdd.Imagen = msEvent.GetBuffer();
                    EventToAdd.Inicio = dtpEventStart.Value;
                    EventToAdd.Fin = dtpEventEnds.Value;
                    EventToAdd.Asistentes = Convert.ToInt32(numEventAssistants.Value);
                    EventToAdd.AreaID = Convert.ToInt32(cmbEventArea.SelectedValue.ToString());
                    EventToAdd.Area = cmbEventArea.SelectedIndex.ToString();
                    if (EventDBO.AddEvent(EventToAdd))
                    {
                        MessageBox.Show("Se agregó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdatingEvent();
                    }
                    else
                    {
                        MessageBox.Show("Falló al agregarse.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (txtEventName.Text.Length <= 10 || txtEventDescription.Text.Length <= 0)
            {
                MessageBox.Show("Campos incompletos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (picEventImage.Image is null)
            {
                MessageBox.Show("Agrega una imagen!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpEventEnds.Value <= dtpEventStart.Value)
            {
                MessageBox.Show("Verifica las fechas!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numEventAssistants.Value <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida en el campo 'Asistentes'!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EventDatabase EventToUpdate = new EventDatabase();
                EventToUpdate.EventoID = Convert.ToInt32(numEventID.Value);
                EventToUpdate.Titulo = txtEventName.Text;
                EventToUpdate.Objetivo = txtEventDescription.Text;
                MemoryStream msEvent = new MemoryStream();
                picEventImage.Image.Save(msEvent, ImageFormat.Bmp);
                EventToUpdate.Imagen = msEvent.GetBuffer();
                EventToUpdate.Inicio = dtpEventStart.Value;
                EventToUpdate.Fin = dtpEventEnds.Value;
                EventToUpdate.Asistentes = Convert.ToInt32(numEventAssistants.Value);
                EventToUpdate.AreaID = Convert.ToInt32(cmbEventArea.SelectedValue.ToString());
                EventToUpdate.Area = cmbEventArea.SelectedIndex.ToString();
                if (EventDBO.UpdateEvent(EventToUpdate))
                {
                    MessageBox.Show("Se actualizó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingEvent();
                }
                else
                {
                    MessageBox.Show("Falló al actualizarse");
                }
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            int idToDelete = Convert.ToInt32(numEventID.Value);
            DialogResult dr = MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (EventDBO.DeleteEvent(idToDelete))
                {
                    MessageBox.Show("Registro eliminado exitosamente!");
                    UpdatingEvent();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                return;
            }
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numCollectionID_ValueChanged(object sender, EventArgs e)
        {
            UpdatingCollection();
        }

        private void btnAddNewCollection_Click(object sender, EventArgs e)
        {
            if (txtCollectionName.Text.Length == 0)
            {
                MessageBox.Show("El campo 'Nombre' está vacío!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CollectionDatabase col = new CollectionDatabase();
                col.ColeccionID = Convert.ToInt32(numEventID.Value);
                col.Coleccion = txtCollectionName.Text;
                col.TipoID = Convert.ToInt32(cmbTypes.SelectedValue.ToString());
                col.GeneroID = Convert.ToInt32(cmbGender.SelectedValue.ToString());
                if (CollectionDBO.AddCollection(col))
                {
                    MessageBox.Show("Se agregó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingCollection();
                }
                else
                {
                    MessageBox.Show("Falló al agregarse.");
                }
            }
        }

        private void btnUpdateCollection_Click(object sender, EventArgs e)
        {
            if (txtCollectionName.Text.Length == 0)
            {
                MessageBox.Show("El campo 'Nombre' está vacío!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                CollectionDatabase col = new CollectionDatabase();
                col.ColeccionID = Convert.ToInt32(numEventID.Value);
                col.Coleccion = txtEventName.Text;
                col.TipoID = Convert.ToInt32(cmbTypes.SelectedValue.ToString());
                col.GeneroID = Convert.ToInt32(cmbGender.SelectedValue.ToString());
                if (CollectionDBO.UpdateCollection(col))
                {
                    MessageBox.Show("Se actualizó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingCollection();
                }
                else
                {
                    MessageBox.Show("Falló al actualizarse");
                }
            }

        }

        private void btnDeleteCollection_Click(object sender, EventArgs e)
        {
            int idToDelete = Convert.ToInt32(numCollectionID.Value);
            DialogResult dr = MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (EventDBO.DeleteEvent(idToDelete))
                {
                    MessageBox.Show("Registro eliminado exitosamente!");
                    UpdatingEvent();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                return;
            }
        }

        private void tspEventsButton_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgShowEvents);
            UpdatingEvent();
        }

        private void btnRefreshCollections_Click(object sender, EventArgs e)
        {
            UpdatingEvent();
        }

        private void btnEditCollections_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgEditEvent);
            UpdatingEvent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0 || txtUserOccupation.Text.Length == 0 || txtUserDir.Text.Length == 0 ||
                txtUserInst.Text.Length == 0 || txtUserMail.Text.Length == 0 || txtUserPhone.Text.Length == 0)
            {
                MessageBox.Show("Verifica que todos los campos estén llenos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (picUser.Image is null)
            {
                MessageBox.Show("Selecciona una foto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserDatabase col = new UserDatabase();
                col.UsuarioID = Convert.ToInt32(numUserID.Value);
                col.Usuario = txtUserName.Text;
                col.Ocupacion = txtUserOccupation.Text;
                col.Direccion = txtUserDir.Text;
                col.Institucion = txtUserInst.Text;
                col.Image = Convertir_Imagen_Bytes(picUser.Image);
                col.Telefono = "+503" + txtUserPhone.Text;
                col.Correo = txtUserMail.Text;

                if (UserDBO.AddUser(col))
                {
                    MessageBox.Show("Se agregó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingCollection();
                    UpdatingUser();
                    tclTools.SelectTab(tpgShowUsers);
                }
                else
                {
                    MessageBox.Show("Falló al agregarse.");

                }
            }
        }


        private void btnSelectUser_Click(object sender, EventArgs e)
        {
                ofdSelectUserImage.Filter = "Imagenes|*.jpg; *.png";
                ofdSelectUserImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofdSelectUserImage.Title = "Seleccionar Imagen";
                if (ofdSelectUserImage.ShowDialog() == DialogResult.OK)
                {
                    picUser.Image = Image.FromFile(ofdSelectUserImage.FileName);
                }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0 || txtUserOccupation.Text.Length == 0 || txtUserDir.Text.Length == 0 ||
                           txtUserInst.Text.Length == 0 || txtUserMail.Text.Length == 0 || txtUserPhone.Text.Length == 0)
            {
                MessageBox.Show("Verifica que todos los campos estén llenos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (picUser.Image is null)
            {
                MessageBox.Show("Selecciona una foto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserDatabase col = new UserDatabase();
                col.UsuarioID = Convert.ToInt32(numUserID.Value);
                col.Usuario = txtUserName.Text;
                col.Ocupacion = txtUserOccupation.Text;
                col.Direccion = txtUserDir.Text;
                col.Institucion = txtUserInst.Text;
                col.Image = Convertir_Imagen_Bytes(picUser.Image);
                col.Telefono = "+503" + txtUserPhone.Text;
                col.Correo = txtUserMail.Text;

                if (UserDBO.UpdateUser(col))
                {
                    MessageBox.Show("Se actualizó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingUser();
                    tclTools.SelectTab(tpgShowUsers);
                    
                }
                else
                {
                    MessageBox.Show("Falló al actualizarse");
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
                int idToDelete = Convert.ToInt32(numUserID.Value);
                DialogResult dr = MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    if (UserDBO.DeleteUser(idToDelete))
                    {
                        MessageBox.Show("Registro eliminado exitosamente!");
                    UpdatingUser();
                    tclTools.SelectTab(tpgShowUsers);
                }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                else
                {
                    return;
                }
        }

        private void numUserID_ValueChanged(object sender, EventArgs e)
        {
            UpdatingUser();
        }

        private void tspEjemplares_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpsShowEj);
        }

        private void btnSelectPort_Click(object sender, EventArgs e)
        {
            ofdSelectBook.Filter = "Imagenes|*.jpg; *.png";
            ofdSelectBook.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSelectBook.Title = "Seleccionar Imagen";
            if (ofdSelectBook.ShowDialog() == DialogResult.OK)
            {
                picBook.Image = Image.FromFile(ofdSelectBook.FileName);
            }
        }

        private void btnNewEj_Click(object sender, EventArgs e)
        {
            if (txtEjName.Text.Length == 0)
            {
                MessageBox.Show("Verifica que todos los campos estén llenos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (picBook.Image is null)
            {
                MessageBox.Show("Selecciona una foto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BookDatabase col = new BookDatabase();
                col.EjemplarID = Convert.ToInt32(numEjID.Value);
                col.EjemplarName = txtEjName.Text;
                col.Portada = Convertir_Imagen_Bytes(picBook.Image);
                col.FechaPub = dtPub.Value;
                col.EditorialID = Convert.ToInt32(cmbEditorial.SelectedValue.ToString());
                col.ColeccionID = Convert.ToInt32(cmbCollection.SelectedValue.ToString());
                col.FormatoID = Convert.ToInt32(cmbFormat.SelectedValue.ToString());
                col.IdiomaID = Convert.ToInt32(cmbLanguage.SelectedValue.ToString());
                col.EtiquetaID = Convert.ToInt32(cmbEjTag.SelectedValue.ToString());

                if (BookDBO.AddBook(col))
                {
                    MessageBox.Show("Se agregó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingBook();
                }
                else
                {
                    MessageBox.Show("Falló al agregarse.");

                }
            }
        }

        private void btnUpdateEj_Click(object sender, EventArgs e)
        {
            if (txtEjName.Text.Length == 0)
            {
                MessageBox.Show("Verifica que todos los campos estén llenos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (picBook.Image is null)
            {
                MessageBox.Show("Selecciona una foto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BookDatabase col = new BookDatabase();
                col.EjemplarID = Convert.ToInt32(numEjID.Value);
                col.EjemplarName = txtEjName.Text;
                col.Portada = Convertir_Imagen_Bytes(picBook.Image);
                col.FechaPub = dtPub.Value;
                col.EditorialID = Convert.ToInt32(cmbEditorial.SelectedValue.ToString());
                col.ColeccionID = Convert.ToInt32(cmbCollection.SelectedValue.ToString());
                col.FormatoID = Convert.ToInt32(cmbFormat.SelectedValue.ToString());
                col.IdiomaID = Convert.ToInt32(cmbLanguage.SelectedValue.ToString());
                col.EtiquetaID = Convert.ToInt32(cmbEjTag.SelectedValue.ToString());

                if (BookDBO.UpdateBook(col))
                {
                    MessageBox.Show("Se actualizó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatingBook();
                }
                else
                {
                    MessageBox.Show("Falló al actualizarse..");

                }
            }
        }

        private void btnDeleteEj_Click(object sender, EventArgs e)
        {
            int idToDelete = Convert.ToInt32(numUserID.Value);
            DialogResult dr = MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            { 
                if (BookDBO.DeleteBook(idToDelete))
                {
                    MessageBox.Show("Registro eliminado exitosamente!");
                    UpdatingBook();
                    tclTools.SelectTab(tpsShowEj);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                return;
            }
        }

        private void numEjID_ValueChanged(object sender, EventArgs e)
        {
            UpdatingBook();
        }

        private void mostrarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgShowEvents);
            UpdatingEvent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgEditEvent);
            UpdatingEvent();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgCollections);
            UpdatingCollection();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgEditCollections);
            UpdatingCollection();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpsShowEj);
            this.eJEMPLARTableAdapter.Fill(this.databankPOObjDataSet1.EJEMPLAR);
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgEditEj);
            UpdatingBook();
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgShowUsers);
            UpdatingUser();
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgEditUsers);
            
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgPrest);
        }

        private void reservasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tclTools.SelectTab(tpgRes);
        }

    }
 }



