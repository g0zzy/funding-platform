using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Extensions
{
    public static class ValidationExtensions
    {
        /// <summary>
        /// Returns object's value if not null, otherwise throws ArgumentNullException
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value of the object</param>
        /// <param name="paramName">Name of the parameter</param>
        /// <returns></returns>
        public static T ThrowIfNull<T>(this T value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return value;
        }
    }
}
