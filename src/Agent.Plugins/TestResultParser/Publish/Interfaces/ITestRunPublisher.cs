﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Agent.Plugins.TestResultParser.TestResult;

namespace Agent.Plugins.TestResultParser.Publish
{
    /// <summary>
    /// Interface for the publishing the TestRun Data
    /// </summary>
    public interface ITestRunPublisher
    {
        /// <summary>
        /// Publishs the given the test run
        /// </summary>
        /// <param name="testRun"></param>
        Task PublishAsync(TestRun testRun);
    }
}
