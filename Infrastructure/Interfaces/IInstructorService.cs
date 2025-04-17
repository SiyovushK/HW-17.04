using Domain.DTOs.InstructorDTOs;
using Domain.Response;

namespace Infrastructure.Interfaces;

public interface IInstructorService
{
    Task<Response<GetInstructorDTO>> CreateInstructor(CreateInstructorDTO createInstructor);
    Task<Response<GetInstructorDTO>> UpdateInstructor(int InstructorId, GetInstructorDTO updateInstructor);
    Task<Response<string>> DeleteInstructor(int InstructorId);
    Task<Response<List<GetInstructorDTO>>> GetAllInstructors();
}