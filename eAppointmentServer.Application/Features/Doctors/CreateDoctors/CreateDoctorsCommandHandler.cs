using AutoMapper;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.CreateDoctor;

internal sealed class CreateDoctorsCommandHandler(
    IDoctorRepository doctorRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateDoctorsCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateDoctorsCommand request, CancellationToken cancellationToken)
    {
        Doctor doctors = mapper.Map<Doctor>(request);
        
        await doctorRepository.AddAsync(doctors,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Doctor was added succcesfully!";

    }
}
