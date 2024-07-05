﻿using eAppointmentServer.Domain.Enums;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.CreateDoctor;

public sealed record class CreateDoctorCommand(
    string FirstName,
    string LastName,
    int DepartmentValue,
    int OfficeNumber): IRequest<Result<string>>;
