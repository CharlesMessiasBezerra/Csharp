﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidator;

namespace ModerStore.Shared.Entities
{
     public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            Id  = Guid.NewGuid();
        }

        public Guid Id { get; private  set; }
    }
}
