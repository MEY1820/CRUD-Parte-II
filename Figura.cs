using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    class Figura
    {
        //propiedades
        public int _figuraId { get; set; }
        public string _nombre { get; set; }
        public string _angulo { get; set; }
        public string _lados { get; set; }
        
        //instancia a la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla Figura
        public MySqlDataReader getAllFigura()
        {
            string query = "SELECT figuraid,nombre,angulo,lados, FROM figura";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditFigura(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO figura(nombre, angulo, lados)" +
                    "VALUES ('" + _nombre + "', '" + _angulo + "', '" + _lados + "', ')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE figura SET "
                    + "title='" + _nombre + "' ,"
                    + "subtitle='" + _angulo + "',"
                    + "isbn='" + _lados + "',"
                    + "WHERE "
                    + "bookId='" + _figuraId + "'";
                crud.executeQuery(query);
                return true;
            }
            return false;
        }

        //metodo para eliminar
        public Boolean deleteFigura()
        {
            string query = "DELETE FROM figura WHERE figuraId='" + _figuraId + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}