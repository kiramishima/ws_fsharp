module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule (appointmentDateDescription: string): DateTime = 
    DateTime.Parse appointmentDateDescription

let hasPassed (appointmentDate: DateTime): bool = 
    DateTime.Now > appointmentDate

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    appointmentDate.TimeOfDay >= TimeSpan(12, 0, 0) && appointmentDate.TimeOfDay < TimeSpan(18, 0, 0)

let description (appointmentDate: DateTime): string =
    $"""You have an appointment on {appointmentDate.ToString("M/d/yyyy h:mm:ss tt")}."""

let anniversaryDate(): DateTime =
    DateTime(DateTime.Now.Year, 9, 15)