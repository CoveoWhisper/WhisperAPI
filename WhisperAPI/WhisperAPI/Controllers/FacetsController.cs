﻿using Microsoft.AspNetCore.Mvc;
using WhisperAPI.Models.Queries;
using WhisperAPI.Services.Context;
using WhisperAPI.Services.Facets;

namespace WhisperAPI.Controllers
{
    [Route("/Whisper/[Controller]")]
    public class FacetsController : ContextController
    {
        private readonly IFacetsService _facetsService;

        public FacetsController(IFacetsService facetsService, IContexts contexts)
            : base(contexts)
        {
            this._facetsService = facetsService;
        }

        /// <summary>
        /// Returns all facet values from a list of facet name.
        /// </summary>
        /// <param name="query">Query containing all the facet name</param>
        /// <returns>A list of facets</returns>
        [HttpPost]
        public IActionResult GetFacetsValues([FromBody] FacetQuery query)
        {
            var facetsValues = this._facetsService.GetFacetValues(query.FacetsName);
            return this.Ok(facetsValues);
        }
    }
}
