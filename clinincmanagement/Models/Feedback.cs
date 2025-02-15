﻿using System;
using System.Collections.Generic;

namespace clinincmanagement.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public int UserId { get; set; }

    public string Message { get; set; } = null!;

    public int? Rating { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
