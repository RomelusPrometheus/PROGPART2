using System;
using System.ComponentModel.DataAnnotations;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }

        [Required]
        public string LecturerId { get; set; } = string.Empty;

        [Required]
        [Range(0.1, 10000)]
        public double HoursWorked { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double HourlyRate { get; set; }

        public double TotalAmount => Math.Round(HoursWorked * HourlyRate, 2);

        [StringLength(2000)]
        public string? Notes { get; set; }

        [StringLength(260)]
        public string? DocumentFileName { get; set; }

        [StringLength(2000)]
        public string? DocumentPath { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Pending";

        public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;

        public DateTime? DateReviewed { get; set; }

        public string? ReviewedById { get; set; }

        internal void CalculateClaimAmount(int v1, double v2)
        {
            throw new NotImplementedException();
        }

        internal bool IsClaimValid(string contractNumber)
        {
            throw new NotImplementedException();
        }
    }
}
