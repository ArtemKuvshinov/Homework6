using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Homework6.Services.Interfaces;
using Homework6.Common.Swagger;
using Homework6.Models.DTO;
using AutoMapper;
using Homework6.Models.Requests.ConstructionCompany;
using Homework6.Models.Responses.ConstructionCompany;
using System.Threading;

namespace Homework6.Controllers
{
    /// <summary>
    /// Контроллер для сущности Застройщик.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.ConstructionCompany)]
    public class ConstructionCompanyController : Controller
    {
        private readonly ILogger<ConstructionCompanyController> _logger;
        private readonly IConstructionCompanyService _constructionCompanyService;
        private readonly IMapper _mapper;

        public ConstructionCompanyController(IConstructionCompanyService constructionCompanyService, ILogger<ConstructionCompanyController> logger, IMapper mapper)
        {
            _constructionCompanyService = constructionCompanyService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение Застройщика по Id.
        /// </summary>
        /// <returns>Cущность Застройщика.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ConstructionCompanyResponse))]
        public IActionResult GetById(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Construction/GetById was requested.");
             var response = _constructionCompanyService.Get(id, cancellationToken);
            return Ok(_mapper.Map<ConstructionCompanyResponse>(response));
        }

        /// <summary>
        ///  Получение списка застройщиков.
        /// </summary>
        /// <returns>Коллекция сущностей Застройщик</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ConstructionCompanyResponse>))]
        public IActionResult Get(CancellationToken cancellationToken)
        {
            _logger.LogInformation("ConstructionCompany/Get was requested.");
            var response = _constructionCompanyService.Get(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<ConstructionCompanyResponse>>(response));
        }

        /// <summary>
        /// Добавление нового застройщика.
        /// </summary>
        /// <param name="newBuilding">Новая сущность "Застройщик"</param>
        /// <returns>Добавлненная сущность "Застройщик"</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ConstructionCompanyResponse), 200)]
        public IActionResult Post(CreateConstructionCompanyRequest request)
        {
            _logger.LogInformation("ConstructionCompany/Post was requested.");
            _constructionCompanyService.Create(_mapper.Map<ConstructionCompanyDTO>(request));
            return Ok(request);
        }

        /// <summary>
        /// Изменение сущности Застройщик.
        /// </summary>
        /// <returns>Измененная сущность Застройщик.</returns>
        [HttpPut]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ConstructionCompanyResponse))]
        public IActionResult Put(UpdateConstructionCompanyRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("ConstructionCompany/Put was requested.");
            _constructionCompanyService.Update(_mapper.Map<ConstructionCompanyDTO>(request));
            var updatedEntity = _constructionCompanyService.Get(request.Id, cancellationToken);
            return Ok(updatedEntity);
        }

        /// <summary>
        /// Удаление сущностей Застройщик.
        /// </summary>
        [HttpDelete]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("ConstructionCompany/Delete was requested.");
            _constructionCompanyService.Delete(ids);
            return NoContent();
        }
    }
}