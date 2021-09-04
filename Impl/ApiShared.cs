using itsellSharedlibrary.Domain;
using Liper.Publicador.Common.SystemCommon;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
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
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
