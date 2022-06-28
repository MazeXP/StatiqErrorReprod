//
//  Program.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Globalization;
using Statiq.App;
using Statiq.Common;
using Statiq.Docs;

namespace Remora.Discord.DocsGenerator;

/// <summary>
/// The main class of the program.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Defines the main entrypoint of the program.
    /// </summary>
    /// <param name="args">The arguments provided to the program.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static async Task<int> Main(string[] args)
    {
        return await Bootstrapper
            .Factory
            .CreateDocs(args)
            .RunAsync();
    }
}
