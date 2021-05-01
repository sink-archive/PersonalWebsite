<script>
	import GithubIcon from '../../components/GithubIcon.svelte';
</script>


<h1>ExType <GithubIcon repo="ExType" /></h1>
<p class="subtitle">Next generation type conversions for .NET</p>

<h3>Built-in type conversion</h3>
<p>
    Type conversions in .NET are somewhat clumsy and disjointed.
    Every object implements the <code>object</code> type, and therefore has the <code>.ToString()</code> method.
    <code>.ToString()</code> makes getting strings for types easy. It also makes it easy for developers to add custom
    converters to string for their classes. This is nice, except that no other built-in types have had this treatment.
</p>

<p>
    ExType adds methods to convert between all built-in types using the same <code>.To&#123;Type&#125;()</code> methods.
    It tries to make an intelligent guess about how you intended to convert,
    compared to the methods in <code>System.Convert</code>,
    which tend to throw an error if the value isnt easily convertible.
</p>

<p>
    Of course, ExType still may throw an error, however this is much rarer.
    Instead it will try to sensibly and reasonably get a value. To read up on how this works precisely,
    read the docs page <a href="//github.com/cainy-a/ExType/wiki/BuiltinOverview">here</a>.
</p>

<h3>Custom type conversion</h3>
<p>
    ExType can also convert between custom classes.
    It does this by looking for any members shared between the two classes.
    Then it will (only for properties and fields), copy the values if possible between them.
    Any values that are in the source but not the target are ignored,
    any in the target but not the source are assigned <code>default</code>.
    To check the standard values for <code>default</code> see
    <a href="//docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values">here</a>.
</p>

<h3>Data methods</h3>
<p>
    By including the optional <code>ExType.Data</code> lib, you can very easily create and read both
    <a href="//json.org">JSON</a> and <a href="//msgpack.org">MessagePack</a>.
</p>

<p>
    Simply use <code>object.ToJson()</code>, <code>object.Pack()</code> to create JSON or MessagePack,
    and then <code>string.FromJson&lt;T&gt;()</code>, <code>byte[].UnPack&lt;T&gt;()</code> to read it to an object
    of give type <code>T</code>.
</p>

<p>
    In addition, MessagePack can be directly converted to JSON for readability by humans,
    or JSON can be converted directly to MessagePack to take up less space.
    This is easy with <code>byte[].MsgPackToJson()</code> and <code>string.MsgPackToJson()</code>.
</p>

<p>
    All data functions can optionally be passed a <code>bool</code> to specify whether to convert
    private members, but this is false by default.
</p>

<h3>Stream tools</h3>
<p>
    Do you hate dealing with <code>Stream</code>s? Well ExType may make them easier to deal with for you!
    If you have a function requiring a stream as input yet you just want to pass a string (common in encryption),
    then simply call <code>string.ToStream()</code>. This returns a <code>MemoryStream</code>,
    but this will be implicitly converted to a <code>Stream</code> if passed as a parameter that requires
    a <code>Stream</code>.
    
    This stream will be returned to position 0, so you can start reading it right away.
</p>

<p>
    You can also read an entire stream to a string easily, though do be aware that for some streams this could
    result in multiple gigabytes of data being read into memory, or even get stuck reading a stream forever
    (or until you run out of memory :P).
    This can be done easily with <code>Stream.ReadStringToEnd()</code>.
    You can pass a custom encoding to this function if you wish,
    but by default it will use <code>Encoding.Default</code>
</p>

<a href="//github.com/cainy-a/ExType/blob/master/assets/original_plan.jpg">See my original plans for ExType, on some rough paper.</a>
