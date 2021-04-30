<script>
	import GithubIcon from '../../components/GithubIcon.svelte';
	import Highlight  from 'svelte-highlight';
   	import bash from "svelte-highlight/src/languages/bash";
    import "svelte-highlight/src/styles/base16-monokai.css";
</script>

<h1>Reggie <GithubIcon repo="reggie" /></h1>

<h2>sed alternative - Painless regex replace from the CLI</h2>
<h3>This screenshot should explain all you need to know</h3>
<img alt="image"
     src="//raw.githubusercontent.com/cainy-a/reggie/master/screenshot.png"
     style="width: 100%" />

<h3>Example</h3>
<p>
    Patch usrbg for Vizality (based on my previous script <a href="//gist.github.com/cainy-a/f29ed1dc9e1b348d4f2436fa18e95db9">here</a>)
    (this was tested with fish, <code>\n</code> may work differently in other shells)
    <Highlight language={bash} code="reggie usrbg.css '\\[data-user-id=&quot;(.{17,18})&quot;\\]:not\\(img\\)' '$&,'\n'[vz-user-id=&quot;$1&quot;]:not(img)' patched.css
mv patched.css usrbg.css" />
</p>

<h3>I don't want replace, I want find!!!</h3>
<p>
    For a great alternative to <code>grep</code>, look at ripgrep by BurntSushi on GitHub
    <GithubIcon user="BurntSushi" repo="ripgrep" />
</p>

<h3>Install it</h3>
<p>
    Arch Linux with <code>yay</code>:
	<Highlight language={bash} code="yay -S reggie-git" />
</p>
<p>
    Arch Linux:
    <Highlight language={bash} code="wget &quot;https://aur.archlinux.org/cgit/aur.git/snapshot/reggie-git.tar.gz&quot;
tar -xzf reggie-git.tar.gz
cd reggie-git
makepkg -si" />
</p>
<p>
    Any Linux:
	<Highlight language={bash} code="wget &quot;https://github.com/cainy-a/reggie/archive/refs/heads/master.tar.gz&quot;
tar -xzf master.tar.gz
cd reggie-master
dotnet build
# sudo is used here, doas or just running as root will also work.
sudo mv Reggie/bin/Debug/net5.0/ /usr/lib/reggie/
sudo ln /usr/lib/reggie/Reggie /usr/bin/reggie" />
</p>
