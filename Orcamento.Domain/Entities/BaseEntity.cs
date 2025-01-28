﻿namespace Orcamento.Domain.Entities
{
    public class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
