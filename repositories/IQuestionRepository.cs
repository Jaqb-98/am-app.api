using Api.Model;

namespace Api.Repository;

public interface IQuestionRepository{
	Task<Question> GetQuestion();

	Task<bool> SubmitAnswer(int questionId, Answer answer);
	Task CreateQuestion(Question question);

}