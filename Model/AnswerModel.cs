namespace Api.Model;

public class AnswerModel {

	public int Id {get; set;}
	public Answer option {get; set;}
	public virtual Question question {get; set;}
	public string Content {get; set;}

}