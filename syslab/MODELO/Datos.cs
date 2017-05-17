using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SYSLAB.CTRL
{
    public static class Datos
    {
        public static string idusuario = "admin";
        
        public static decimal ptjeIVA
        {
            get
            {
                var ps = new CTRL.Persistencia();
                ps.AbrirConexion();

                var reg = ps.DB.PARAMETROs.Where(c => c.NOMBRE == "IVA").SingleOrDefault();
                if (reg != null)
                    return decimal.Parse(reg.VALOR);
                else
                    return 0;
            }
        }
        public static decimal ptjeRetencion
        {
            get
            {
                var ps = new CTRL.Persistencia();
                ps.AbrirConexion();

                var reg = ps.DB.PARAMETROs.Where(c => c.NOMBRE == "Retención").SingleOrDefault();
                if (reg != null)
                    return decimal.Parse(reg.VALOR);
                else
                    return 0;
            }
        }
        public static decimal ptjePercepción
        {
            get
            {
                var ps = new CTRL.Persistencia();
                ps.AbrirConexion();

                var reg = ps.DB.PARAMETROs.Where(c => c.NOMBRE == "Percepción").SingleOrDefault();
                if (reg != null)
                    return decimal.Parse(reg.VALOR);
                else
                    return 0;
            }
        }
    }
}
