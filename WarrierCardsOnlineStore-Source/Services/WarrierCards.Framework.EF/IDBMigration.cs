#region File Header
/*
Copyright Rudolph Technologies
All rights are reserved. Reproduction or transmission in whole or in part, in any form or by any means, 
electronic, mechanical or otherwise, is prohibited without the prior written consent of the copyright owner.
File Name	: IDBMigration.cs
Description	: Implementation of <see cref="GenericRepository" /> class that uses Entity Framework
              for the repository operations. Also Implements IUnitOfWork pattern as well as IDisposible.
Log
Date			Author			Comment
09-Jul-2015		Prince          Class created
*/
#endregion File Header

namespace WarrierCards.Framework.EF
{
    /// <summary>
    /// Defines the base class for the EF migration classes
    /// to identify the associated version number of the migration
    /// </summary>
    public interface IDBMigration
    {
        /// <summary>
        /// Gets or sets associated version number of the migration
        /// </summary>
        string VersionNumber { get; }
    }
}
