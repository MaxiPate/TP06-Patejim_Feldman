using Newtonsoft.Json;
public class DatoFamiliar{
    [JsonProperty]
    public int Id{get;private set;}
    [JsonProperty]
    public int IdUsuario{get;private set;}
    [JsonProperty]
    public string Nombre{get;private set;}
    [JsonProperty]
    public string Apellido{get;private set;}
    [JsonProperty]
    public string Parentesco{get;private set;}
    [JsonProperty]
    public string Descripcion{get;private set;}
    public DatoFamiliar(int Id, int IdUsuario, string Nombre,string Apellido, string Parentesco, string Descripcion)
    {
        this.Id=Id;
        this.IdUsuario=IdUsuario;
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Parentesco=Parentesco;
        this.Descripcion=Descripcion;
    }
}
