//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncomeSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncomeSource()
        {
            this.Incomes = new HashSet<Income>();
        }
    
        public int Id { get; set; }
        public string SourceName { get; set; }
        public string JobOf { get; set; }
        public string PositionName { get; set; }
        public bool ActiveJob { get; set; }
        public Nullable<decimal> EstimatedIncome { get; set; }
        public string PayFrequency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes { get; set; }
    }
}
