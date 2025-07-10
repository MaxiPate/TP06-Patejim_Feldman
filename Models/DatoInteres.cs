using Newtonsoft.Json;
public class DatoInteres{
    [JsonProperty]
    public int Id{get;private set;}
    [JsonProperty]
    public int IdUsuario{get;private set;}
    [JsonProperty]
    public int TipoInteres{get;private set;}
    [JsonProperty]
    public string Interes{get;private set;}

    public DatoInteres(int Id, int IdUsuario, int TipoInteres, string Interes){
        this.Id=Id;
        this.IdUsuario=IdUsuario;
        this.TipoInteres=TipoInteres;
        this.Interes=Interes;
    }
}