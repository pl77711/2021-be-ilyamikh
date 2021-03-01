using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemesApi.Models;

namespace ThemesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemesControlles : ControllerBase
    {
        private readonly IThemeRepository _themeRepository;

        public ThemesControlles(IThemeRepository context) {
            _themeRepository = context;
        }

    }
}
