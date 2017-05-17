using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SYSLAB.CTRL
{
    public class Persistencia
    {
        protected dbDataContext _DB;

        public Persistencia()
        {

        }

        public dbDataContext DB
        {
            get { return _DB; }
        }

        #region Conexión

        public void AbrirConexion()
        {
            var db = new dbDataContext();
            db.Connection.Open();
            this._DB = db;
        }

        public void CerrarConexion()
        {
            if (_DB.Connection.State == System.Data.ConnectionState.Open)
                _DB.Connection.Close();
            _DB.Dispose();
        }

        #endregion

        #region Transacciones


        public void IniciarTransaccion(System.Data.IsolationLevel IsoNivel = 
            System.Data.IsolationLevel.ReadCommitted)
        {
            var db = new dbDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsoNivel);
            this._DB = db;
        }

        public void FinalizarTransaccion()
        {
            _DB.SubmitChanges();
            _DB.Transaction.Commit();
            if (_DB.Connection.State == System.Data.ConnectionState.Open)
                _DB.Connection.Close();
            _DB.Dispose();
        }

        public void RevertirTransaccion()
        {
            _DB.Transaction.Rollback();
            if (_DB.Connection.State == System.Data.ConnectionState.Open)
                _DB.Connection.Close();
            _DB.Dispose();
        }



        #endregion

        #region AccesoDatos
        public T SelPorLlave<T>(String id) where T : class
        {
            try
            {
                // get the table by the type passed in
                var table = this._DB.GetTable<T>();

                // get the metamodel mappings (database to
                // domain objects)
                MetaModel modelMap = table.Context.Mapping;

                // get the data members for this type
                ReadOnlyCollection<MetaDataMember> dataMembers
                = modelMap.GetMetaType(typeof(T)).DataMembers;

                // find the primary key field name
                // by checking for IsPrimaryKey
                string pk =
                (dataMembers.Single<MetaDataMember>(m =>
                m.IsPrimaryKey)).Name;

                // return a single object where the id argument
                // matches the primary key field value
                return table.SingleOrDefault<T>(delegate(T t)
                {
                    String memberId = t.GetType().GetProperty(pk).GetValue(t, null).ToString();
                    return memberId.ToString() == id.ToString();
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.\nEl registro no ha sido encontrado", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public List<T> SelectAll<T>() where T : class
        {
            try
            {
                var table = this._DB.GetTable<T>().ToList<T>();

                return table;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.\nLos datos no fueron encontrados", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        #endregion

        static void ErrorHandler(Exception ex)
        {
            
        }
    }
}
