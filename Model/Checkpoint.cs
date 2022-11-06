namespace Api.Model;

public class Checkpoint {

	public int Id {get; set;}
	public double Lat {get; set;}
	public double Lng {get; set;}
	public string Name {get; set;} = null!;
}