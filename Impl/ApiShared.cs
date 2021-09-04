using itsellSharedlibrary.Domain;
using Liper.Publicador.Common.SystemCommon;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsellSharedlibrary.Impl
{
    public class ApiShared : IDisposable
    {
        private bool disposedValue;
        DataInput datafinput;
        public void ReadDataToken(JObject values)
        {
            datafinput = JsonConvert.DeserializeObject<DataInput>(values.ToString());
        }

        [ExportRpa(Etiqueta = "Funciones Strings", Name = "Obtener ruta local", Parametros = "{'text':'','key':''}", Comentario = "Obtiene la ruta local de procesamiento")]
        public async Task<String> GetCurrentDirectory(JObject values)
        {
            //serializa el objeto que recibe
            ReadDataToken(values);
            return await Task.FromResult(Directory.GetCurrentDirectory());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~ApiShared()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
