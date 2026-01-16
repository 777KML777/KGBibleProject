namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterAppService _app;
        public CharacterController( ICharacterAppService app )
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult Get() =>
            Ok(_app.Read());
        // public List<CharacterDto> Get() =>
        //     _services.Read();

        [HttpPost]
        public ActionResult Create(CharacterInputModel obj) =>
            Ok(_app.Create(obj));
        // public void Create(CharacterInputModel characterInputModel) =>
        //     _services.Create(characterInputModel);

        // [HttpGet("{id}")]
        // public CharacterDto GetById(int id) =>
        //     _services.GetById(id);

        // [HttpPut("{id}")]
        // public void Update(int id, CharacterInputModel characterInputModel) =>
        //     _services.Update(id, characterInputModel);

    }
}

