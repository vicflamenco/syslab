using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SYSLAB.CTRL
{
    public static class Examenes
    {
        public static class Solicitudes
        {
            public static bool AgregarSolicitud(dbDataContext db, long idpaciente, long iddoctor, DateTime fecha_emision,
                DateTime fecha_entrega, int no_factura, string nombres, string giro, string nit, string nrc, bool retencion,
                bool CFiscal, decimal ptje_iva, decimal ptje_retencion, decimal monto_gravado, decimal monto_iva, decimal subtotal,
                decimal monto_exento, decimal monto_retencion, decimal monto_total, List<SOLICITUD_DETALLE> Detalle)
            {
                try
                {
                    var reg = new SOLICITUD
                    {
                        ID_SOLICITUD = ((long?)db.SOLICITUDs.Select(c => (long?)c.ID_SOLICITUD).Max() ?? 0) + 1,
                        ID_DOCTOR = iddoctor,
                        ID_PACIENTE = idpaciente,
                        ID_USUARIO_CREO = CTRL.Datos.idusuario,
                        FECHA_EMISION = fecha_emision,
                        FECHA_ENTREGA = fecha_entrega,
                        NO_FACTURA = no_factura,
                        NOMBRES = nombres,
                        GIRO = giro,
                        NIT = nit,
                        NRC = nrc,
                        CREDITO_FISCAL = CFiscal,
                        RETENCION = retencion,
                        PORCENTAJE_IVA = ptje_iva,
                        PORCENTAJE_RETENCION = ptje_retencion,
                        MONTO_GRAVADO = monto_gravado,
                        MONTO_IVA = monto_iva,
                        SUBTOTAL = subtotal,
                        MONTO_EXENTO = monto_exento,
                        MONTO_RETENCION = monto_retencion,
                        TOTAL = monto_total
                    };

                    //ASIGNANDO ID A DETALLE
                    foreach (SOLICITUD_DETALLE item in Detalle)
                        item.ID_SOLICITUD_DETALLE = reg.ID_SOLICITUD + "-" + Detalle.IndexOf(item);

                    reg.SOLICITUD_DETALLEs.AddRange(Detalle);

                    db.SOLICITUDs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarSolicitud(dbDataContext db, long idsolicitud, long idpaciente, long iddoctor,
                DateTime fecha_emision, DateTime fecha_entrega, int no_factura, string nombres, string giro, string nit,
                string nrc, bool retencion, bool CFiscal, decimal ptje_iva, decimal ptje_retencion, decimal monto_gravado,
                decimal monto_iva, decimal subtotal, decimal monto_exento, decimal monto_retencion, decimal monto_total,
                List<SOLICITUD_DETALLE> Detalle)
            {
                try
                {
                    var reg = db.SOLICITUDs.Where(c => c.ID_SOLICITUD == idsolicitud).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.ID_DOCTOR = iddoctor;
                        reg.ID_PACIENTE = idpaciente;
                        reg.FECHA_MODIFICADA = DateTime.Now;
                        reg.FECHA_EMISION = fecha_emision;
                        reg.FECHA_ENTREGA = fecha_entrega;
                        reg.NO_FACTURA = no_factura;
                        reg.NOMBRES = nombres;
                        reg.GIRO = giro;
                        reg.NIT = nit;
                        reg.NRC = nrc;
                        reg.CREDITO_FISCAL = CFiscal;
                        reg.RETENCION = retencion;
                        reg.PORCENTAJE_IVA = ptje_iva;
                        reg.PORCENTAJE_RETENCION = ptje_retencion;
                        reg.MONTO_GRAVADO = monto_gravado;
                        reg.MONTO_IVA = monto_iva;
                        reg.SUBTOTAL = subtotal;
                        reg.MONTO_EXENTO = monto_exento;
                        reg.MONTO_RETENCION = monto_retencion;
                        reg.TOTAL = monto_total;

                        reg.SOLICITUD_DETALLEs.Clear();
                        db.SubmitChanges();

                        //ASIGNANDO ID A DETALLE
                        foreach (SOLICITUD_DETALLE item in Detalle)
                            item.ID_SOLICITUD_DETALLE = reg.ID_SOLICITUD + "-" + Detalle.IndexOf(item);

                        reg.SOLICITUD_DETALLEs.AddRange(Detalle);

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarSolicitud(dbDataContext db, long idsolicitud)
            {
                try
                {
                    var reg = db.SOLICITUDs.Where(c => c.ID_SOLICITUD == idsolicitud).Single();

                    db.SOLICITUDs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static class Resultados
        {
            public static bool ProcesarResultados(dbDataContext db, long id_solicitud, long id_analisis, string obserb,
                List<SOLICITUD_RESULTADO_DETALLE> Resultados)
            {
                try
                {
                    SOLICITUD_RESULTADO reg;

                    reg = db.SOLICITUD_RESULTADOs.Where(c => c.ID_ANALISIS == id_analisis &&
                                                    c.ID_SOLICITUD == id_solicitud).SingleOrDefault();

                    if (reg == null)
                    {
                        reg = new SOLICITUD_RESULTADO
                        {
                            ID_SOLICITUD_RESULTADO = id_solicitud.ToString() + "-" + id_analisis.ToString(),
                            ID_ANALISIS = id_analisis,
                            ID_SOLICITUD = id_solicitud,
                            ID_USUARIO_CREA = CTRL.Datos.idusuario,
                            FECHA_CREADO = DateTime.Now,
                            OBSERVACIONES = obserb
                        };

                        foreach (var item in Resultados)
                            item.ID_RESULTADO_DETALLE = reg.ID_SOLICITUD_RESULTADO + "-" + Resultados.IndexOf(item).ToString();

                        reg.SOLICITUD_RESULTADO_DETALLEs.AddRange(Resultados);

                        db.SOLICITUD_RESULTADOs.InsertOnSubmit(reg);

                        db.SubmitChanges();
                    }
                    else
                    {
                        reg.ID_USUARIO_MOD = CTRL.Datos.idusuario;
                        reg.OBSERVACIONES = obserb;
                        reg.FECHA_MODIFICADO = DateTime.Now;

                        reg.SOLICITUD_RESULTADO_DETALLEs.Clear();
                        db.SubmitChanges();

                        foreach (var item in Resultados)
                            item.ID_RESULTADO_DETALLE = reg.ID_SOLICITUD_RESULTADO + "-" + Resultados.IndexOf(item).ToString();

                        reg.SOLICITUD_RESULTADO_DETALLEs.AddRange(Resultados);

                        db.SubmitChanges();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al procesar el resultado.\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return false;
                }
            }
        }

        public static class Cotizaciones
        {
            public static bool AgregarCotizacion(dbDataContext db, long idpaciente, long iddoctor, DateTime fecha_emision,
               DateTime fecha_entrega, string nombres, string giro, string nit, string nrc, bool retencion,
               bool CFiscal, decimal ptje_iva, decimal ptje_retencion, decimal monto_gravado, decimal monto_iva, decimal subtotal,
               decimal monto_exento, decimal monto_retencion, decimal monto_total, List<COTIZACION_DETALLE> Detalle)
            {
                try
                {
                    var reg = new COTIZACION
                    {
                        ID_COTIZACION = ((long?)db.COTIZACIONs.Select(c => (long?)c.ID_COTIZACION).Max() ?? 0) + 1,
                        ID_DOCTOR = iddoctor,
                        ID_PACIENTE = idpaciente,
                        ID_USUARIO_CREO = CTRL.Datos.idusuario,
                        FECHA_EMISION = fecha_emision,
                        FECHA_ENTREGA = fecha_entrega,
                        NOMBRES = nombres,
                        GIRO = giro,
                        NIT = nit,
                        NRC = nrc,
                        CREDITO_FISCAL = CFiscal,
                        RETENCION = retencion,
                        PORCENTAJE_IVA = ptje_iva,
                        PORCENTAJE_RETENCION = ptje_retencion,
                        MONTO_GRAVADO = monto_gravado,
                        MONTO_IVA = monto_iva,
                        SUBTOTAL = subtotal,
                        MONTO_EXENTO = monto_exento,
                        MONTO_RETENCION = monto_retencion,
                        TOTAL = monto_total
                    };

                    //ASIGNANDO ID A DETALLE
                    foreach (COTIZACION_DETALLE item in Detalle)
                        item.ID_COTIZACION_DETALLE = reg.ID_COTIZACION + "-" + Detalle.IndexOf(item);

                    reg.COTIZACION_DETALLEs.AddRange(Detalle);

                    db.COTIZACIONs.InsertOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EditarCotizacion(dbDataContext db, long idcotizacion, long idpaciente, long iddoctor,
                DateTime fecha_emision, DateTime fecha_entrega, string nombres, string giro, string nit,
                string nrc, bool retencion, bool CFiscal, decimal ptje_iva, decimal ptje_retencion, decimal monto_gravado,
                decimal monto_iva, decimal subtotal, decimal monto_exento, decimal monto_retencion, decimal monto_total,
                List<COTIZACION_DETALLE> Detalle)
            {
                try
                {
                    var reg = db.COTIZACIONs.Where(c => c.ID_COTIZACION == idcotizacion).SingleOrDefault();

                    if (reg == null)
                    {
                        MessageBox.Show("El registro a editar no fue encontrado.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        reg.ID_DOCTOR = iddoctor;
                        reg.ID_PACIENTE = idpaciente;
                        reg.FECHA_MODIFICADA = DateTime.Now;
                        reg.FECHA_EMISION = fecha_emision;
                        reg.FECHA_ENTREGA = fecha_entrega;
                        reg.NOMBRES = nombres;
                        reg.GIRO = giro;
                        reg.NIT = nit;
                        reg.NRC = nrc;
                        reg.CREDITO_FISCAL = CFiscal;
                        reg.RETENCION = retencion;
                        reg.PORCENTAJE_IVA = ptje_iva;
                        reg.PORCENTAJE_RETENCION = ptje_retencion;
                        reg.MONTO_GRAVADO = monto_gravado;
                        reg.MONTO_IVA = monto_iva;
                        reg.SUBTOTAL = subtotal;
                        reg.MONTO_EXENTO = monto_exento;
                        reg.MONTO_RETENCION = monto_retencion;
                        reg.TOTAL = monto_total;

                        reg.COTIZACION_DETALLEs.Clear();
                        db.SubmitChanges();

                        //ASIGNANDO ID A DETALLE
                        foreach (COTIZACION_DETALLE item in Detalle)
                            item.ID_COTIZACION_DETALLE = reg.ID_COTIZACION + "-" + Detalle.IndexOf(item);

                        reg.COTIZACION_DETALLEs.AddRange(Detalle);

                        db.SubmitChanges();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al agregar el registro.\n\n" + ex.Message, "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            public static bool EliminarCotizacion(dbDataContext db, long idcotizacion)
            {
                try
                {
                    var reg = db.COTIZACIONs.Where(c => c.ID_COTIZACION == idcotizacion).Single();

                    db.COTIZACIONs.DeleteOnSubmit(reg);

                    db.SubmitChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static class Procedimientos
        {
            public static bool EnviarCorreo()
            {
                MailMessage theMailMessage = new MailMessage("from@email.com", "to@email.com");
                theMailMessage.Body = "body email message here";
                theMailMessage.Attachments.Add(new Attachment("pathToEmailAttachment"));
                theMailMessage.Subject = "Subject here";

                SmtpClient theClient = new SmtpClient("IP.Address.Of.Smtp");
                theClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential("user@name.com", "password");
                theClient.Credentials = theCredential;
                theClient.Send(theMailMessage);

                return true;
            }

        }
    }
}
