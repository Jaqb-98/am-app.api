using Api.Model;
using Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{

private readonly IQuestionRepository _repository;
    public QuestionController(IQuestionRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    public async Task<ActionResult<Question>> Get()
    {
        var question = await _repository.GetQuestion();
        return question != null ? Ok(question) : NotFound();
    }
    

    [HttpPost]
    public async Task<ActionResult<Question>> Create([FromBody] Question question)
    {
        await _repository.CreateQuestion(question);
        return CreatedAtAction(nameof(Create), question);
    }

    [HttpPost]
    [RouteAttribute("SubmitAnswer")]
    public async Task<ActionResult<bool>> SubmitAnswer(int questionId, Answer answer)
    {
        var isCorrect = await _repository.SubmitAnswer(questionId, answer);
        return isCorrect;
    }
}
