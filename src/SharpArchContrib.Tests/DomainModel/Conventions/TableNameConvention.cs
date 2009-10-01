﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Tests.DomainModel.Conventions
{
    public class TableNameConvention : IClassConvention
    {
        #region IClassConvention Members

        public void Apply(IClassInstance instance)
        {
            instance.Table(Inflector.Net.Inflector.Pluralize(instance.EntityType.Name));
        }

        #endregion
    }
}