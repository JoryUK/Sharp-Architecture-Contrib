﻿namespace Tests.DomainModel.Conventions
{
    using System;

    using FluentNHibernate.Conventions;
    using FluentNHibernate.Conventions.Instances;

    using Inflector.Net;

    public class TableNameConvention : IClassConvention
    {
        [CLSCompliant(false)]
        public void Apply(IClassInstance instance)
        {
            instance.Table(Inflector.Pluralize(instance.EntityType.Name));
        }
    }
}