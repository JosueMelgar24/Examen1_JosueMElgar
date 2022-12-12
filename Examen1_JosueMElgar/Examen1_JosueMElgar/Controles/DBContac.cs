using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Examen1_JosueMElgar.Controllers
{
   public  class DBContac
    {
        readonly SQLiteAsyncConnection _conexion;
        public DBContac()
        {

        }

        //Constructor con parametros
        public DBContac(string dbpath)
        {
            //creando una conexion a base de datos sqlite apartir de path de la base de dtos
            _conexion = new SQLiteAsyncConnection(dbpath);

            //Crear las tablas correspondientes en la base de datos de sqlite
            _conexion.CreateTableAsync<Models.Contactos>().Wait();

        }

        //CRUD - APLICACIONES
        //CREATE

        public Task<int> StoreContac(Models.Contactos contactos)
            
        {
            if(contactos.Id != 0)
            {
                return _conexion.UpdateAsync(contactos);

            }
            else
            {
                return _conexion.InsertAsync(contactos);
            }

        }


        //Actualizar
        public Task<int> SaveContacAsync(Models.Contactos contac)
        {
            if(contac.Id != 0)
            {
                return _conexion.UpdateAsync(contac);

            }
            else
            {
                return _conexion.InsertAsync(contac);
            }
        }

       
        //Read

        public Task<List<Models.Contactos>> listacontactos()
        {
            return _conexion.Table<Models.Contactos>().ToListAsync();
        }

        public Task<Models.Contactos> getempleado(int pid)
        {
            return _conexion.Table<Models.Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> Deleteempleado(Models.Contactos emple)
        {
            return _conexion.DeleteAsync(emple);
        }



    }
}
