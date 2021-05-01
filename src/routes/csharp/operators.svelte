<script>
    import ListItem from '../../components/ListItem.svelte';
</script>

<h1>A complete guide to C# operators</h1>
<p>Part of a set of <a href="/csharp">pages about C#</a>.</p>

<!-- navigation -->
<ul class="list">
    <ListItem href="#simple">Simple Operators</ListItem>
        <ListItem indent=1 href="#misc">Misc</ListItem>
            <ListItem indent=2 href="#unary">Unary Operators</ListItem>
            <ListItem indent=2 href="#increment">Increment</ListItem>
            <ListItem indent=2 href="#decrement">Decrement</ListItem>
        <ListItem indent=1 href="#arithmetic">Basic Arithmetic</ListItem>
            <ListItem indent=2 href="#addition">Addition</ListItem>
            <ListItem indent=2 href="#subtraction">Subtraction</ListItem>
            <ListItem indent=2 href="#multiplication">Multiplication</ListItem>
            <ListItem indent=2 href="#division">Division</ListItem>
            <ListItem indent=2 href="#modulo">Modulo</ListItem>
        <ListItem indent=1 href="#logical-ops">Logical</ListItem>
            <ListItem indent=2 href="#not-gate">NOT</ListItem>
            <ListItem indent=2 href="#and-gate">AND</ListItem>
            <ListItem indent=2 href="#and-gate-sc">AND (short-circuiting)</ListItem>
            <ListItem indent=2 href="#or-gate">OR</ListItem>
            <ListItem indent=2 href="#or-gate-sc">OR (short-circuiting)</ListItem>
            <ListItem indent=2 href="#xor-gate">XOR</ListItem>
        <ListItem indent=1 href="#assignment">Assignment</ListItem>
            <ListItem indent=2 href="#multiple-assignment">Multiple Assignment</ListItem>
        <ListItem indent=1 href="#equality-ops">Equality</ListItem>
            <ListItem indent=2 href="#equality">Equality Operator</ListItem>
            <ListItem indent=2 href="#inequality">Inequality Operator</ListItem>
        <ListItem indent=1 href="#comparison">Comparison</ListItem>
            <ListItem indent=2 href="#less-than">Less than</ListItem>
            <ListItem indent=2 href="#less-than-or-equal">Less than or equal</ListItem>
            <ListItem indent=2 href="#greater-than">Greater than</ListItem>
            <ListItem indent=2 href="#greater-than-or-equal">Greater than or equal</ListItem>
        <!-- TODO: finish navigation -->
        <ListItem href="#">hey future me finish this</ListItem>
</ul>


<!-- content -->
<h2 id="simple">
	Simple Operators (everyone should know these)
</h2>
<h3 id="misc">
	Misc. Operators
</h3>
<h4 id="unary">
	Unary Operators:
	<code >+, -</code>
</h4>
<p>
	The unary positive operator just returns the value of its operand, the
	unary negative operator negates the value of its operand. (Do I really need
	an example???)
</p>
<h4 id="increment">
	Increment Operator:
	<code >++</code>
</h4>
<p>
	This operator will increment the value of its operand by one. For an int,
	double, float, etc it will increment the number. For a char it goes to the
	next Unicode character.
</p>
<h5>
	Postfixing or Prefixing
</h5>
<p>
	Postfixing (putting it on the end) returns the operand and then increments
	it. Prefixing increments before returning.
</p>
<h4 id="decrement">
	Decrement Operator:
	<code >--</code>
</h4>
<p>
	Increment operator but it decreases instead of increasing.
</p>
<h3 id="arithmetic">
	Basic Arithmetic
</h3>
<h4 id="addition">
	Addition:
	<code >+</code>
</h4>
<p>
	The Addition operator adds two values together. It is usually used for
	basic math, for example if given int or double types to operate on, but can
	have other effects, such as concatenating string values.
</p>
<h5>
	Examples:
</h5>
<pre><code>
&gt;&gt; 5 + 5;
&gt; 10
&gt;&gt; "Hello, " + "World!";
&gt; "Hello, World!"
</code></pre>
<h4 id="subtraction">
	Subtraction:
	<code >-</code>
</h4>
<p>
	The Subtraction operator subtracts two values from each another. It works
	with numeric types such as int and double.
</p>
<h5>
	Examples:
</h5>
<pre><code>
&gt;&gt; 10 - 5;
&gt; 5
&gt;&gt; 4.3 - 2.9;
&gt; 1.4
</code></pre>
<h4 id="multiplication">
	Multiplication:
	<code >*</code>
</h4>
<p>
	The Multiplication operator multiplies two values. Works with numeric
	types.
</p>
<h5>
	Examples:
</h5>
<pre><code>
&gt;&gt; 10 * 5;
&gt; 50
&gt;&gt; 4.3 * 2.9;
&gt; 12.47
</code></pre>
<h4 id="division">
	Division:
	<code >/</code>
</h4>
<p>
	The Division operator divides two values. Works with numeric types. If
	given float, double, decimal, or the new half type, it will divide with
	decimals, but if given two int values it will ignore the remainder.
</p>
<h5>
	Examples:
</h5>
<pre><code>
&gt;&gt; 10 / 5;
&gt; 2
&gt;&gt; 10 / 3;
&gt; 3
&gt;&gt; 4.2 / 3;
&gt; 1.4
</code></pre>
<h4 id="modulo">
	Modulo:
	<code >%</code>
</h4>
<p>
	The Modulo operator gets the remainder of an integer division
</p>
<h5>
	Examples:
</h5>
<pre><code>
&gt;&gt; 10 % 5;
&gt; 0
&gt;&gt; 10 % 3;
&gt; 1
</code></pre>
<h3 id="logical-ops">
	Logical Operators
</h3>
<p>
	Logical operators evaluate two values and produce a bool result.
</p>
<h4 id="not-gate">
	Logical NOT:
	<code >!</code>
</h4>
<p>
	The logical NOT gate simply returns the opposite of its operand.
</p>
<h4 id="and-gate">
	Logical AND:
	<code >&amp;</code>
</h4>
<p>
	This operand evaluates both sides, and returns true if they are the same,
	else false.
</p>
<h4 id="and-gate-sc">
	Short-circuiting logical AND:
	<code >&amp;&amp;</code>
</h4>
<p>
	This operand is similar to the standard logical AND, except it will only
	evaluate the right operand if the left operand is true, as if it is false
	the AND gate is guaranteed false and the right operand need not be
	evaluated. You should not use this operator if the right side contains a
	method call that is required to be called when the AND is evaluated.
</p>
<h4 id="or-gate">
	Logical OR:
	<code >|</code>
</h4>
<p>
	This operand evaluates both sides, and returns true if either are true,
	else false.
</p>
<h4 id="or-gate-sc">
	Short-circuiting logical OR:
	<code >||</code>
</h4>
<p>
	This operand is similar to the standard logical OR, except it will only
	evaluate the right operand if the left operand is false, as if it is true
	the OR gate is guaranteed true and the right operand need not be evaluated.
	You should not use this operator if the right side contains a method call
	that is required to be called when the OR is evaluated.
</p>
<h4 id="xor-gate">
	Logical XOR:
	<code >^</code>
</h4>
<p>
	This operator evaluates both sides, and then returns true if one side is
	true and the other isn't, or false if either both are true, or both or
	false.
</p>
<p>
	This operator works basically the same as a not equal operator (!=) for
	bool values.
</p>
<p>
	This operator does not have a short-circuiting version as the left hand
	side cannot be used to guarantee a result.
</p>
<h3 id="equality-ops">
	Equality Operators
</h3>
<h4 id="equality">
	Equality Operator:
	<code >==</code>
</h4>
<p>
	The == operator checks if both sides are equal, and if so returns true,
	else false.
</p>
<p>
	This operator actually has loads of extra complications depending on value
	vs reference equality and what types are passed in. Info here:
	<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/equality-operators#equality-operator-">
		Microsoft Docs.
	</a>
</p>
<h4 id="inequality">
	Inequality Operator:
	<code >!=</code>
</h4>
<p>
	The opposite of the Equality operator.
</p>
<h3 id="comparison">
	Comparison Operators
</h3>
<h4 id="less-than">
	Less Than:
	<code >&lt;</code>
</h4>
<p>
	The less than operator checks if the left side has a lower value than the
	right side. If so, return true, else false. Equal values return false.
</p>
<h4 id="greater-than">
	Greater Than:
	<code >&gt;</code>
</h4>
<p>
	Opposite of less than.
</p>
<h4 id="less-than-or-equal">
	Less Than or Equal:
	<code >&lt;=</code>
</h4>
<p>
	Less than, except equal values return true.
</p>
<h4 id="greater-than-or-equal">
	Greater Than or Equal:
	<code >&gt;=</code>
</h4>
<p>
    Opposite of less than or equal.
</p>
<h3 id="assignment">
    Assignment Operator:
    <code >=</code>
</h3>
<p>
    The assignment operator sets the value of its left operand to that of the
    right operand. For example, when you set variables, you use the assignment
    operator. It returns the left operand.
</p>
<h4 id="multiple-assignment">
    Multiple Assignment
</h4>
<p>
    You can assign multiple values like this: x = y = z, which will be
    evaluated to x = (y = z), setting y equal to z first, and then setting
    <code>x = y</code>, effectively setting both x and y equal to z.
</p>
<h3 id="compound-assignment">
	Compound Assignment:
	<code >+=, -=, *=, /=, %=, |=, &amp;=</code>
</h3>
<p>
	Compound assignment operators are shorthand values for longer statements.
	Let's use addition as an example:
</p>
<p>
	The compound assignment
	<code >x += y</code> is shorthand for
	<code >x = x + y</code>.
</p>
<p>
	It works the same for subtract, multiply, divide, modulo, OR, and AND.
</p>
<h3 id="member-access-ops">
	Simple Member Access
</h3>
<h4 id="member-access">
	Member Access operator:
	<code >.</code>
</h4>
<p>
	Use a dot to access a member of an object.
</p>
<pre><code>
5.ToString(); // "5"
"HeLlO".ToLower() // "hello"
DateTime.Parse("5/12/2020").Month // 12 (there's two here!)
</code></pre>
<h4 id="member-access-index">
	Index Access operator:
	<code >[]</code>
</h4>
<p>
	This operand evaluates the value in the brackets and finds that location in
	an array, list, dictionary, etc.
</p>
<h2 id="advanced">
	More Advanced Operators (hope you like nulls)
</h2>
<h3>
	Bitwise and shift operators
</h3>
<p>
	NO.
</p>
<h3>
	Pointer Related operators
</h3>
<p>
	Also, NO.
</p>
<h3 id="null-conditional-ops">
	Null-Conditional Member Access
</h3>
<h4 id="member-access-nc">
	Null-Conditional Member Access Operator:
	<code >?.</code>
</h4>
<p>
	Checks if the left operand is null, and if so returns null (and
	short-circuits to prevent a NullReferenceException), else evaluates the
	member to access as normal.
</p>
<h4 id="member-access-index-nc">
	Null-Conditional Index Access operator
</h4>
<p>
	Checks if the left operand is null, and if so returns null (and
	short-circuits like ?.), else evaluates the index of a list, array,
	dictionary, etc just like the standard Index Access operator.
</p>
<h3 id="invocation">
	Invocation Expression:
	<code >()</code>
</h3>
<p>
	This operator calls/invokes the method or class constructor referred to as
	the left operand, with the parameters from inside the brackets. It is also
	used to define and implement methods / constructors.
</p>
<h4>
	Classic Casts
</h4>
<p>
	Parentheses can also cast. This method is called a classic cast. See
	<em>Classic Cast / Cast Expression</em> below.
</p>
<h3 id="index-advanced">
	More Advanced Index Operators
</h3>
<p>
	These can all be made null conditional by prefixing with
	<code >?</code>.
</p>
<h4 id="index-advanced-from-end">
	Index from End Access Operator:
	<code >[^]</code>
</h4>
<p>
	In C# 8.0 or later, you can index from the end by using this operator.
	Instead of
	<code >x[y]</code>, you do
	<code >x[^y]</code>.
</p>
<h4 id="index-advanced-range">
	Range Operator:
	<code >[..]</code>
</h4>
<p>
	This can get a range of values. Use it like this:
	<code >x[y..z]</code>.
</p>
<h3 id="casting-type-testing">
	Casting and Type testing
</h3>
<p>
	Casting works similar to overloading, but instead of passing different
	parameters in, you ask for a different return type. This can also be used
	on equations and numeric types.
</p>
<h4 id="is">
	Type testing operator / is operator:
	<code >is</code>
</h4>
<p>
	The type testing operator, a.k.a. the "is operator" checks if the left
	operand, which must be an object instance, can be successfully casted to
	the type passed into the right operand.
</p>
<p>
	For example: 5 is float returns true, because although 5 is an int, it can
	be casted to a float, whilst, for example, "hello" is bool returns false.
</p>
<h4 id="as">
	Cast Operator / as operator:
	<code >as</code>
</h4>
<p>
	This operand will attempt to cast the left operand to the type passed into
	the right operand, and if it cannot, such as attempting to cast the string
	"hello" to an int, it returns null.
</p>
<h4 id="classic-cast">
	Classic Cast / Cast Expression:
	<code >()</code>
</h4>
<p>
	Classic casts will attempt to cast the following value (you may need extra
	parentheses to target what you actually want), and if it cannot, then it
	will throw an
	<code >InvalidCastException</code>.
</p>
<h4 id="typeof">
	Typeof operator:
	<code >typeof</code>
</h4>
<p>
    You can use the Typeof to get the type of an object. You would use it like
    this:
    <code >typeof(x)</code>. The Typeof operator can also be used to differentiate
    between whether the object inherits a type, or is of that type directly,
    especially in combination with the Type testing operator (for more info see
    here:
    <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#type-testing-with-the-typeof-operator">
        Microsoft Docs
    </a>
    ).
</p>
<h3 id="assignment-advanced">
    Advanced Assignment
</h3>
<h4 id="assignment-nc">
	Null-Coalescing Assignment:
	<code>??=</code>
</h4>
<p>
	See Null-Coalescing Assignment under Null-Coalescing Operators below.
</p>
<h4 id="assignment-ref">
	Ref Assignment:
	<code>= ref</code>
</h4>
<p>
	Honestly I dunno. If you feel like it you can have a crack at parsing the
	Microsoft Docs here:
	<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/assignment-operator#ref-assignment-operator">
		Microsoft Docs
	</a>
</p>
<h3 id="lambda">
	Lambda Expressions (this is fun)
</h3>
<p>
	Not really operators in of themselves but do use the lambda operator:
	<code>=&gt;</code>.
</p>
<p>
	Okay honestly explaining these is really hard so imma just describe them
	instead.
</p>
<h4 id="lambda-expression">
	Expression Lambdas:
	<code>(x) =&gt; y</code>
</h4>
<p>
	Expression lambdas return the result of the right side expression, and can
	include method calls.
</p>
<h4 id="lambda-statement">
	Statement Lambdas:
	<code>(x) =&gt; &#123; y &#125;</code>
</h4>
<p>
	Statement lambdas can contain as many statements as you need, however it's
	typically only two or three.
</p>
<h3 id="ternary">
	Ternary Operator:
	<code>x ? y : z</code>
</h3>
<p>
	Ternaries can be seen as short hand for
	<em>"if this then this else that"</em>, where the first value is a bool,
	then the second value (after the ?) is a value to return if the bool is
	true, and the final value if the bool is false.
</p>
<p>
	In C# 9.0 and later, ternaries are target-typed, meaning that you could say
	<code>var x = y ? 5 : "hello";</code> and x would be made either int or string based on
	the value of y.
</p>
<p>
	In C# 8.0 and earlier, ternaries are not target-typed, and they must either
	be the same:
	<code>x ? 5 : 7;</code> or can be implicitly converted to a common type:
	<code>x ? 5 : 7.4;</code>.
</p>
<h3 id="null-forgiving">
	Null-Forgiving Operator:
	<code>!</code>
</h3>
<p>
	Make sure that you postfix the Null-Forgiving operator: if you prefix it
	then its actually a Logical NOT!
</p>
<p>
	You use the Null-Forgiving operator to declare that an object of nullable
	type is not null.
</p>
<p>
	This is useful in Unit Tests as when the compiler may pass a warning as you
	pass a null, you can notify the compiler that a null value is expected by
	passing null!.
</p>
<p>
	You can also use it if you know that a value cannot possibly be null, for
	example if you test the value of a string and then use that string value
	inside your if block, you can add a Null-Forgiving operator to prevent
	compiler warnings of a possible
	<code>NullReferenceException</code>.
</p>
<h3 id="null-coalescing-ops">
	Null-Coalescing Operators
</h3>
<h4 id="null-coalescing">
	Null-Coalescing Operator:
	<code>??</code>
</h4>
<p>
	The Null-Coalescing operator will return the left value if it is not null,
	else return the right value. This operator is short-circuiting, so the
	right value will only be evaluated if the left value is null.
</p>
<h4 id="null-coalescing-assignment">
	Null-Coalescing Assignment:
	<code>??=</code>
</h4>
<p>
	The Null-Coalescing Assignment operator will set the value of the left
	operand to the right operand, but only if the left operand is null. This
	operator is short-circuiting, so the right value will only be evaluated if
	the left value is null.
</p>
<h3 id="await">
	Await operator:
	<code>await</code>
</h3>
<p>
	The await operator will stop the current thread and make it wait for the
	right operand's Task to complete. It will then return the Task's Result
	value.
</p>
<p>
	It must be used inside of an
	<code>async</code> function.
</p>
<h3 id="nameof">
	Nameof expression:
	<code>nameof</code>
</h3>
<p>
	The Nameof expression gets the name of the passed object, as a string. For
	example:
	<code>nameof(x); // "x"</code> and
	<code>nameof(myVariable); // "myVariable"</code>.
</p>
<h3 id="sizeof">
	Sizeof operator:
	<code>sizeof</code>
</h3>
<p>
	The Sizeof operator returns the number of bytes a specified task takes up.
	It requires an unsafe context.
</p>
<h3 id="switch">
	Switch expression:
	<code>switch</code>
</h3>
<p>
	The switch expression is similar to a switch statement, but does not work
	the same way. It allows you to test a value against multiple
	pattern-matching expressions and return a value based on that. See an
	example at
	<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression#basic-example">
		Microsoft Docs.
	</a>
</p>
<h3 id="true-false">
	True and False operators:
	<code>true, false</code>
</h3>
<p>
	Honestly I wouldn't class these as operators but the Microsoft Docs say
	they are so
	<em>sure</em>. True returns a bool with the true value and
	false returns a bool with the false value (kinda obvious).
</p>


<!-- I really cba to convert all of this to use the <Highlight /> stuff so this'll have to do -->
<style>
code {
    font-family: 'Jetbrains Mono', monospace;
    background: #272822;
    color: #f8f8f2;
    padding: .5rem;
    border-radius: .25rem;
    display: inline-block;
}
</style>
