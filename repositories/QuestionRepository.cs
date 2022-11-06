using Api;
using Api.Model;
using Api.Repository;

namespace Api.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _context;

        public QuestionRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public Task<Question> GetQuestion()
        {
            return Task
                .Run(() =>
                {
                    return _context
                        .Questions
                        .OrderBy(r => Guid.NewGuid())
                        .First();
                });
        }

        public Task CreateQuestion(Question question)
        {
            return Task
                .Run(() =>
                {
                    _context.Questions.Add (question);
                    _context.SaveChanges();
                });
        }

        public Task<bool> SubmitAnswer(int questionId, Answer answer)
        {
            return Task
                .Run(() =>
                {
                    var question =
                        _context
                            .Questions
                            .FirstOrDefault(x => x.Id == questionId);

                    if (question == null)
                        throw new Exception("QuestionN not found");

                    if (question.CorrectAnswer == answer)
                        return true;
                    else
                        return false;
                });
        }
    }
}
