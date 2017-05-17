using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.CTRL
{
    public static class Administracion
    {
        public static class Pacientes
        {

            public static bool AgregarPaciente(dbDataContext db, DateTime fecha_nac, 
                string nombres, string giro, string direccion, string telefono, string municipio,
                string depto, string nit, string nrc, bool gran_contribuyente, bool exento,
                bool tasa_cero, bool credito, int credito_dias, string correo, int precio_sel, bool cfiscal)
            {
                    var reg = new PACIENTE
                    {
                        ID_PACIENTE = ((long?)db.PACIENTEs.Select(c => (long?)c.ID_PACIENTE).Max() ?? 0) + 1,
                        NOMBRES = nombres, TELEFONO = telefono, FECHA_NAC = fecha_nac, GIRO = giro,
                        DIRECCION = direccion, MUNICIPIO = municipio, DEPARTAMENTO = depto, NIT = nit,
                        NRC = nrc, GRAN_CONTRIBUYENTE = gran_contribuyente, EXENTO = exento,
                        TASA_CERO = tasa_cero, CREDITO = credito, CREDITO_DIAS = credito_dias, CORREO = correo,
                        PRECIO_SEL = precio_sel, CREDITO_FISCAL = cfiscal
                    };
                    db.PACIENTEs.InsertOnSubmit(reg);
                    db.SubmitChanges();
                    return true;
            }

            public static bool EditarPaciente(dbDataContext db, long idpaciente, DateTime fecha_nac, 
                string nombres, string giro, string direccion, string telefono, string municipio,
                string depto, string nit, string nrc, bool gran_contrib, bool exento, bool tasa_cero,
                bool credito, int credito_dias, string correo, int precio_sel, bool cfiscal)
            {
                    var reg = db.PACIENTEs.Where(c => c.ID_PACIENTE == idpaciente).SingleOrDefault();
                    if (reg == null) return false;
                    else
                    {
                        reg.NOMBRES = nombres;  reg.TELEFONO = telefono; reg.FECHA_NAC = fecha_nac;
                        reg.GIRO = giro; reg.DIRECCION = direccion; reg.MUNICIPIO = municipio;
                        reg.DEPARTAMENTO = depto; reg.NRC = nrc; reg.GRAN_CONTRIBUYENTE = gran_contrib;
                        reg.EXENTO = exento; reg.TASA_CERO = tasa_cero; reg.CREDITO = credito;
                        reg.CREDITO_DIAS = credito_dias; reg.CORREO = correo; reg.PRECIO_SEL = precio_sel;
                        reg.CREDITO_FISCAL = cfiscal; db.SubmitChanges(); return true;
                    }
            }

            public static bool AsignarPaciente(dbDataContext db, long idpaciente, long? idSector)
            {
                try
                {
                    var reg = db.PACIENTEs.Where(c => c.ID_PACIENTE == idpaciente).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.ID_SECTOR = idSector;
                        db.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al asignar el paciente.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            
            public static bool EliminarPaciente(dbDataContext db, long idpaciente)
            {
                    var reg = db.PACIENTEs.Where(c => c.ID_PACIENTE == idpaciente).Single();
                    if (reg.SOLICITUDs.Count > 0) return false;
                    db.PACIENTEs.DeleteOnSubmit(reg);
                    db.SubmitChanges();
                    return true;
            }
        }

        public static class Doctores
        {
            public static bool AgregarDoctores(dbDataContext db, string nombres, string direccion, string telefono,
                string nit, string dui, string correo, string clinica_nombre, string clinica_telefono)
            {
                try
                {
                    var reg = new DOCTORE
                    {
                        ID_DOCTOR = ((long?)db.DOCTOREs.Select(c => (long?)c.ID_DOCTOR).Max() ?? 0) + 1,
                        NOMBRES = nombres,
                        TELEFONO = telefono,
                        DIRECCION = direccion,
                        NIT = nit,
                        DUI = dui,
                        CORREO = correo,
                        CLINICA_NOMBRE = clinica_nombre,
                        CLINICA_TELEFONO = clinica_telefono
                    };

                    db.DOCTOREs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error no controlado al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarDoctores(dbDataContext db, long iddoctor, string nombres, string direccion, string telefono,
                string nit, string dui, string correo, string clinica_nombre, string clinica_telefono)
            {
                try
                {
                    var reg = db.DOCTOREs.Where(c => c.ID_DOCTOR == iddoctor).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.NOMBRES = nombres;
                        reg.TELEFONO = telefono;
                        reg.DIRECCION = direccion;
                        reg.NIT = nit;
                        reg.DUI = dui;
                        reg.CORREO = correo;
                        reg.CLINICA_NOMBRE = clinica_nombre;
                        reg.CLINICA_TELEFONO = clinica_telefono;

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarDoctores(dbDataContext db, long iddoctor)
            {
                try
                {
                    var reg = db.DOCTOREs.Where(c => c.ID_DOCTOR == iddoctor).Single();

                    if (reg.SOLICITUDs.Count > 0)
                        return false;

                    db.DOCTOREs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Método que se invoca para agregar una empresa a la base de datos
        public static class Empresas
        {
            public static bool AgregarEmpresa(dbDataContext db, string nombre, string giro, 
                string direccion, string municipio, string depto, string nit, string nrc, 
                bool gran_contribuyente, bool credito, int credito_dias, string correo, 
                string contacto_nombre,string contacto_nit, string contacto_correo, 
                string contacto_telefono)
            {
                    // Se instancia un objeto de la clase EMPRESA
                    var reg = new EMPRESA
                    {
                        ID_EMPRESA = ((long?)db.EMPRESAs.Select(c => (long?)c.ID_EMPRESA).Max() ?? 0) + 1,
                        // Para asignar un identificador a la empresa 
                        NOMBRE = nombre,
                        GIRO = giro,
                        DIRECCION = direccion,
                        MUNICIPIO = municipio,
                        DEPARTAMENTO = depto,
                        NIT = nit,
                        NRC = nrc,
                        GRAN_CONTRIBUYENTE = gran_contribuyente,
                        CREDITO = credito,
                        CREDITO_DIAS = credito_dias,
                        CORREO = correo,
                        CONTACTO_NOMBRE = contacto_nombre,
                        CONTACTO_TELEFONO = contacto_telefono,
                        CONTACTO_NIT = contacto_nit,
                        CONTACTO_CORREO = contacto_correo
                    };

                    db.EMPRESAs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
            }

            public static bool EditarEmpresa(dbDataContext db, long idempresa, string nombre, string giro, string direccion, string municipio,
                string depto, string nit, string nrc, bool gran_contribuyente, bool credito, int credito_dias, string correo,
                string contacto_nombre, string contacto_nit, string contacto_correo, string contacto_telefono)
            {
                try
                {
                    var reg = db.EMPRESAs.Where(c => c.ID_EMPRESA == idempresa).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.NOMBRE = nombre;
                        reg.GIRO = giro;
                        reg.DIRECCION = direccion;
                        reg.MUNICIPIO = municipio;
                        reg.DEPARTAMENTO = depto;
                        reg.NIT = nit;
                        reg.NRC = nrc;
                        reg.GRAN_CONTRIBUYENTE = gran_contribuyente;
                        reg.CREDITO = credito;
                        reg.CREDITO_DIAS = credito_dias;
                        reg.CORREO = correo;
                        reg.CONTACTO_NOMBRE = contacto_nombre;
                        reg.CONTACTO_TELEFONO = contacto_telefono;
                        reg.CONTACTO_NIT = contacto_nit;
                        reg.CONTACTO_CORREO = contacto_correo;

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarEmpresa(dbDataContext db, long idempresa)
            {
                try
                {
                    var reg = db.EMPRESAs.Where(c => c.ID_EMPRESA == idempresa).Single();

                    if (reg.EMPRESA_SECTORs.Count > 0)
                        return false;

                    if (reg.DOCTOREs.Count > 0)
                        return false;

                    db.EMPRESAs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }


            public static bool AgregarSector(dbDataContext db, long id_empresa, string nombre, string descripcion)
            {
                try
                {
                    var reg = new EMPRESA_SECTOR
                    {
                        ID_EMPRESA = id_empresa,
                        ID_SECTOR = ((long?)db.EMPRESA_SECTORs.Select(c => (long?)c.ID_SECTOR).Max() ?? 0) + 1,
                        NOMBRE = nombre,
                        DESCRIPCION = descripcion
                    };

                    db.EMPRESA_SECTORs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error no controlado.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarSector(dbDataContext db, long id_sector, string nombre, string descripcion)
            {
                try
                {
                    var reg = db.EMPRESA_SECTORs.Where(c => c.ID_SECTOR == id_sector).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.NOMBRE = nombre;
                        reg.DESCRIPCION = descripcion;
                    };

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error no controlado.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarSector(dbDataContext db, long id_sector)
            {
                try
                {
                    var reg = db.EMPRESA_SECTORs.Where(c => c.ID_SECTOR == id_sector).Single();

                    if (reg.PACIENTEs.Count > 0)
                        return false;

                    db.EMPRESA_SECTORs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static class Clasificaciones
        {
            public static bool AgregarCategoria(dbDataContext db, string nombre, string descripcion)
            {
                try
                {
                    var reg = new CATEGORIA
                    {
                        ID_CATEGORIA = ((long?)db.CATEGORIAs.Select(c => (long?)c.ID_CATEGORIA).Max() ?? 0) + 1,
                        NOMBRE = nombre,
                        DESCRIPCION = descripcion
                    };

                    db.CATEGORIAs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarCategoria(dbDataContext db, long idcategoria, string nombre, string descripcion)
            {
                try
                {
                    var reg = db.CATEGORIAs.Where(c => c.ID_CATEGORIA == idcategoria).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.NOMBRE = nombre;
                        reg.DESCRIPCION = descripcion;

                        db.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarCategoria(dbDataContext db, long idcategoria)
            {
                try
                {
                    var reg = db.CATEGORIAs.Where(c => c.ID_CATEGORIA == idcategoria).Single();

                    if (reg.FAMILIAs.Count > 0)
                        return false;

                    db.CATEGORIAs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool AgregarFamilia(dbDataContext db, long idcategoria, string nombre, string descripcion)
            {
                try
                {
                    var reg = new FAMILIA
                    {
                        ID_FAMILIA = ((long?)db.FAMILIAs.Select(c => (long?)c.ID_FAMILIA).Max() ?? 0) + 1,
                        ID_CATEGORIA = idcategoria,
                        NOMBRE = nombre,
                        DESCRIPCION = descripcion
                    };

                    db.FAMILIAs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarFamilia(dbDataContext db, long idfamilia, string nombre, string descripcion)
            {
                try
                {
                    var reg = db.FAMILIAs.Where(c => c.ID_FAMILIA == idfamilia).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.NOMBRE = nombre;
                        reg.DESCRIPCION = descripcion;

                        db.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarFamilia(dbDataContext db, long idfamilia)
            {
                try
                {
                    var reg = db.FAMILIAs.Where(c => c.ID_FAMILIA == idfamilia).Single();

                    if (reg.ANALISIs.Count > 0)
                        return false;

                    db.FAMILIAs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static class CatalogoAnalisis
        {
            public static bool AgregarAnalisis(dbDataContext db, long idfamilia, string nombre, string descripcion, decimal p1, decimal p2, decimal p3, List<ANALISIS_DATO> Datos)
            {
                try
                {
                    var reg = new ANALISI
                    {
                        ID_ANALISIS = ((long?)db.ANALISIs.Select(c => (long?)c.ID_ANALISIS).Max() ?? 0) + 1,
                        ID_FAMILIA = idfamilia,
                        NOMBRE = nombre,
                        DESCRIPCION = descripcion,
                        PRECIO1 = p1,
                        PRECIO2 = p2,
                        PRECIO3 = p3
                    };

                    foreach (ANALISIS_DATO item in Datos)
                        item.ID_ANALISIS_DATO = reg.ID_ANALISIS.ToString() + "-" + Datos.IndexOf(item);

                    reg.ANALISIS_DATOs.AddRange(Datos);

                    db.ANALISIs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarAnalisis(dbDataContext db, long idanalisis, long idfamilia, string nombre, string descripcion, decimal p1, decimal p2, decimal p3, List<ANALISIS_DATO> Datos)
            {
                try
                {
                    var reg = db.ANALISIs.Where(c => c.ID_ANALISIS == idanalisis).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.ID_FAMILIA = idfamilia;
                        reg.NOMBRE = nombre;
                        reg.DESCRIPCION = descripcion;
                        reg.PRECIO1 = p1;
                        reg.PRECIO2 = p2;
                        reg.PRECIO3 = p3;

                        reg.ANALISIS_DATOs.Clear();
                        db.SubmitChanges();

                        foreach (ANALISIS_DATO item in Datos)
                            item.ID_ANALISIS_DATO = reg.ID_ANALISIS.ToString() + "-" + Datos.IndexOf(item);

                        reg.ANALISIS_DATOs.AddRange(Datos);

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al ediar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarAnalisis(dbDataContext db, long idanalisis)
            {
                try
                {
                    var reg = db.ANALISIs.Where(c => c.ID_ANALISIS == idanalisis).Single();

                    if (reg.SOLICITUD_DETALLEs.Count > 0)
                        return false;

                    db.ANALISIs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static class Talonarios
        {
            public static bool AgregarTalonario(dbDataContext db, long id_doctor, DateTime fecha_entrega,
                int cantidad)
            {
                try
                {
                    var reg = new TALONARIO
                    {
                        ID_TALONARIO = ((long?)db.TALONARIOs.Select(c => (long?)c.ID_TALONARIO).Max() ?? 0) + 1,
                        ID_DOCTOR = id_doctor,
                        FECHA = fecha_entrega,
                        CANTIDAD = cantidad
                    };

                    db.TALONARIOs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error no controlado al agregar el registro.\n\n" + ex.Message, "SysLab",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarTalonario(dbDataContext db, long idTalonario, long idDoctor, int cantidad,
                DateTime fechaEntrega)
            {
                try
                {
                    var reg = db.TALONARIOs.Where(c => c.ID_TALONARIO == idTalonario).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.ID_DOCTOR = idDoctor;
                        reg.CANTIDAD = cantidad;
                        reg.FECHA = fechaEntrega;

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarTalonario(dbDataContext db, long idTalonario)
            {
                try
                {
                    var reg = db.TALONARIOs.Where(c => c.ID_TALONARIO == idTalonario).Single();

                    db.TALONARIOs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        public static class Usuarios
        {

            public static bool AgregarUsuario(dbDataContext db, string clave, string telefono, string identificador,
                string nombres, string correo, string apellidos, string tipo)
            {
                try
                {
                    MD5.MD5 encrip = new MD5.MD5(clave);

                    var reg = new USUARIO
                    {
                        ID_USUARIO = identificador,
                        NOMBRES = nombres,
                        APELLIDOS = apellidos,
                        TELEFONO = telefono,
                        FECHA_CREADO = DateTime.Now,
                        CORREO = correo,
                        TIPO = tipo,
                        CLAVE = encrip.FingerPrint
                    };

                    db.USUARIOs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error no controlado al agregar el usuario.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarUsuario(dbDataContext db, string identificador, string clave, string telefono, 
                string nombres, string correo, string apellidos, string tipo)
            {
                try
                {
                    var reg = db.USUARIOs.Where(c => c.ID_USUARIO == identificador).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        MD5.MD5 encrip = new MD5.MD5(clave);

                        reg.NOMBRES = nombres;
                        reg.APELLIDOS = apellidos;
                        reg.TELEFONO = telefono;
                        reg.TIPO = tipo;
                        reg.CORREO = correo;
                        if (clave != string.Empty)
                            reg.CLAVE = encrip.FingerPrint;

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al editar el usuario.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarUsuario(dbDataContext db, string identificador)
            {
                try
                {
                    var reg = db.USUARIOs.Where(c => c.ID_USUARIO == identificador).Single();

                    if (reg.SOLICITUDs.Count > 0 || reg.SOLICITUD_RESULTADOs.Count > 0)
                        return false;

                    db.USUARIOs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool IniciarSesion(dbDataContext db, string identificador, string contra)
            {
                try
                {
                    var reg = db.USUARIOs.Where(c => c.ID_USUARIO == identificador).SingleOrDefault();

                    if (reg != null && reg.CLAVE == contra)
                        return true;
                    
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
