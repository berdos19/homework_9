using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentTeacherManagement.Core.Interfaces;
using StudentTeacherManagement.DTOs;

namespace StudentTeacherManagement.Controllers;

[ApiController]
[Route("groups")]
public class GroupController : ControllerBase
{
    private readonly IGroupService _groupService;
    private readonly IMapper _mapper;

    public GroupController(IGroupService groupService, IMapper mapper)
    {
        _groupService = groupService;
        _mapper = mapper;
    }

    [HttpGet]
    [Authorize]
    public async Task<ActionResult<IEnumerable<GroupDTO>>> GetGroups([FromQuery] string? name = null,
                                                                  [FromQuery] int skip = 0,
                                                                  [FromQuery] int take = 10)
    {
        var groups = await _groupService.GetGroups(name, skip, take);
        Console.WriteLine("endpoint");
        return Ok(_mapper.Map<IEnumerable<GroupDTO>>(groups));
    }
}