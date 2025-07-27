#region Systema
    global using System.ComponentModel.DataAnnotations;
    global using System.Text.Json.Serialization;
    global using BCrypt.Net;
#endregion

#region Microsoft
    global using Microsoft.EntityFrameworkCore;
    global using Microsoft.AspNetCore.Mvc;
    global using Microsoft.OpenApi.Models;
    global using Microsoft.AspNetCore.Authorization;
#endregion

#region Frapi
    global using Frapi.Source.Container.Interface;
    global using Frapi.Source.Core.Repository;
    global using Frapi.Source.Core.Model;
    global using Frapi.Source.Core.Context;
    global using Frapi.Source.Setup.Extensions;
#endregion