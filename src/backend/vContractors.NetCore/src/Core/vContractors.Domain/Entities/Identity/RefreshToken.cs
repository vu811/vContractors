﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace vContractors.Domain.Entities.Identity;

[Owned]
public class RefreshToken
{
    [Key]
    [JsonIgnore]
    public Guid Id { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public bool IsExpired => DateTime.UtcNow >= Expires;
    public DateTime Created { get; set; }
    public string? CreatedByIp { get; set; }
    public DateTime? Revoked { get; set; }
    public string? RevokedByIp { get; set; }
    public string? ReplacedByToken { get; set; }
    public bool IsActive => Revoked == null && !IsExpired;
}