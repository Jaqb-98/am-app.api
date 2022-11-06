namespace Api.Model;

public class Question {

	public int Id {get; set;}
	public string Content {get; set;}
	public virtual ICollection<AnswerModel> Answers {get; set;}
	public Answer CorrectAnswer {get; set;}


}