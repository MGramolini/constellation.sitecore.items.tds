namespace Constellation.Sitecore.Items.Tds
{
	using System.Collections.Generic;

	using HedgehogDevelopment.SitecoreProject.VSIP.CodeGeneration.Models;

	/// <summary>
	/// The sitecore field equality comparer.
	/// </summary>
	public class SitecoreFieldEqualityComparer : IEqualityComparer<SitecoreField>
	{
		#region Public Methods and Operators

		/// <summary>
		/// Determines whether the specified objects are equal.
		/// </summary>
		/// <returns>
		/// true if the specified objects are equal; otherwise, false.
		/// </returns>
		/// <param name="x">
		/// The first object of type <paramref name="HedgehogDevelopment.SitecoreProject.VSIP.CodeGeneration.Models.SitecoreField"/> to compare.
		/// </param>
		/// <param name="y">
		/// The second object of type <paramref name="HedgehogDevelopment.SitecoreProject.VSIP.CodeGeneration.Models.SitecoreField"/> to compare.
		/// </param>
		public bool Equals(SitecoreField x, SitecoreField y)
		{
			if (ReferenceEquals(x, y))
			{
				return true;
			}

			if (x == null || y == null)
			{
				return false;
			}

			return x.ID == y.ID;
		}

		/// <summary>
		/// Returns a hash code for the specified object.
		/// </summary>
		/// <returns>
		/// A hash code for the specified object.
		/// </returns>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> for which a hash code is to be returned.
		/// </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// The type of <paramref name="obj"/> is a reference type and
		///     <paramref name="obj"/> is null.
		/// </exception>
		public int GetHashCode(SitecoreField obj)
		{
			return obj.ID.ToString().GetHashCode();
		}

		#endregion
	}
}