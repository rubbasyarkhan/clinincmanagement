﻿namespace clinincmanagement.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public int UserId { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? ContactNumber { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual User User { get; set; } = null!;
}
