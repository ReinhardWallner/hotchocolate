using System;
using HotChocolate.Language;

namespace HotChocolate.Types.Filters
{
    public interface IObjectFilterFieldDescriptor
        : IFluent
    {
        /// <summary>
        /// Defines the name of the field to filter.
        /// </summary>
        /// <param name="value">The name of the field.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="value"/> is <c>null</c> or
        /// <see cref="string.Empty"/>.
        /// </exception>
        IObjectFilterFieldDescriptor Name(NameString value);

        /// <summary>
        /// Defines the filter binding behavior.
        ///
        /// The default binding behavior is set to
        /// <see cref="BindingBehavior.Implicit"/>.
        /// </summary>
        /// <param name="behavior">
        /// The binding behavior.
        ///
        /// Implicit:
        /// The boolean filter field descriptor will add
        /// all available boolean filter operations.
        ///
        /// Explicit:
        /// All filter operations have to be specified explicitly.
        /// </param>
        IObjectFilterFieldDescriptor BindFilters(
            BindingBehavior bindingBehavior);

        /// <summary>
        /// Defines that all filter operations have to be specified explicitly.
        /// </summary>
        IObjectFilterFieldDescriptor BindExplicitly();

        /// <summary>
        /// The string filter field descriptor will add
        /// all available string filter operations.
        /// </summary>
        IObjectFilterFieldDescriptor BindImplicitly();

        /// <summary>
        /// Allow object filter operations.
        /// </summary>
        IObjectFilterOperationDescriptor AllowObject();

        IObjectFilterFieldDescriptor Type<TInputType>()
            where TInputType : FilterInputType;

        IObjectFilterFieldDescriptor Type<TInputType>(TInputType inputType)
            where TInputType : FilterInputType;

        IObjectFilterFieldDescriptor Type(ITypeNode typeNode);

        IObjectFilterFieldDescriptor Type(Type type);
    }
}
