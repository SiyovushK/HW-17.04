using Domain.DTOs.CourseAssignmentDTOs;
using Domain.Response;

namespace Infrastructure.Interfaces;

public interface ICourseAssignmentService
{
    Task<Response<GetCourseAssignmentDTO>> CreateCourseAssignment(CreateCourseAssignmentDTO createCourseAssignment);
    Task<Response<GetCourseAssignmentDTO>> UpdateCourseAssignment(int CourseAssignmentId, GetCourseAssignmentDTO updateCourseAssignment);
    Task<Response<string>> DeleteCourseAssignment(int CourseAssignmentId);
    Task<Response<List<GetCourseAssignmentDTO>>> GetAllCourseAssignments();
}