﻿using FluentAssertions;

namespace NetCoreTests;

public class NameOfShould
{
	[Test]
	public void ForNamespace_ReturnTheLastPart()
	{
		var nameOfNamespace = nameof(NUnit.Framework);

		nameOfNamespace.Should().Be("Framework");
	}
}
