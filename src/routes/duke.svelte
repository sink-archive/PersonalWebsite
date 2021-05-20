<script>
 const items = [
     {
         name: "Duke Matcher Bundle",
         link: "/duke/dist.zip",
         description: "A bundle containing Duke Matcher, Source ports, the needed GRP files, and v1 and v2 of Ripcity 2020. To install extract zip and run the .bat"
     }
 ];
</script>

<h1>Duke Nukem 3D stuff and things</h1>

<table>
    <tr>
        <th>Name</th>
        <th>Link</th>
        <th>Description</th>
    </tr>
    {#each items as item}
        <tr>
            <td>{item.name}</td>
            <td><a href={item.link}>{item.link}</a></td>
            <td>{item.description}</td>
        </tr>
    {/each}
</table>

<p>Styles are broken but I CBA to fix it.</p>
