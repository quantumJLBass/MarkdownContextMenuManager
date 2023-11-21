using Microsoft.Win32;

public class RegistryManager
{
    public void AddMDFileType()
    {
        using (var key = Registry.ClassesRoot.CreateSubKey(".md\\ShellNew"))
        {
            key.SetValue("NullFile", "", RegistryValueKind.String);
        }

        using (var key = Registry.ClassesRoot.CreateSubKey(".md"))
        {
            key.SetValue("", "VSCode.md");
        }

        using (var key = Registry.ClassesRoot.CreateSubKey("VSCode.md"))
        {
            key.SetValue("", "Markdown File");
        }

        using (var key = Registry.ClassesRoot.CreateSubKey(@"VSCode.md\shell\open\command"))
        {
            key.SetValue("", "\"C:\\Program Files\\Microsoft VS Code\\Code.exe\" \"%1\"");
        }
    }
}
