# Что такое Управление приложениями для бизнеса?

<div align="center">
<img src="https://raw.githubusercontent.com/HotCakeX/.github/main/Pictures/Gifs/Application%20Control%20for%20Business.gif" alt="App Control for Business introduction">
</div>

<br>

Очень важно управлять приложениями для защиты компьютеров в современных условиях, и это значительно лучше традиционных антивирусных решений. Управление приложениями использует индивидуальный доступ. Раньше все приложения считались надежными, а теперь приложения должны заслужить доверие, прежде чем их можно будет запустить.

Устройства с политиками Управления приложениями могут управляться централизованно (через MDM, Intune и т.д.) или быть частными, домашними устройствами. Это может быть компьютер человека, которого вы хотите надежно защитить, [чтобы даже сам владелец не мог случайно или намеренно навредить системе](https://github.com/HotCakeX/Harden-Windows-Security/wiki/The-Strength-of-Signed-App-Control-Policies).

<br>

> [!IMPORTANT]\
> Используйте [AppControl Manager](https://github.com/HotCakeX/Harden-Windows-Security/wiki/AppControl-Manager) для всех задач по управлению Управлением приложениями и целостностью кода. Он масштабируем, прост в использовании, готов к использованию на предприятиях, готов к использованию на виртуальных машинах Azure и, что более важно, он бесплатен, имеет открытый код и всегда будет таким.

<br>

Управление приложениями даёт полный контроль над вашей системой и системами, которыми вы управляете. В отличие от других решений, оно избавляет от необходимости постоянно искать и блокировать новые вирусы. После настройки системы и определения приложений и файлов, которым разрешено выполняться, всё остальное автоматически блокируется.

**Пришло время перейти от реактивного подхода к проактивному.**

<br>

## Что такое Управление приложениями простыми словами?

По умолчанию вы можете установить любую программу и запустить любой файл в своей системе. Эти файлы могут быть как подписанными, так и неподписанными. Подписанные файлы поставляются с сертификатом, подтверждающим их подлинность, а Windows ведет [список доверенных сертификатов](https://learn.microsoft.com/en-us/windows-server/identity/ad-cs/certificate-trust).

Управление приложениями — это функция безопасности, которая регулирует и ограничивает запуск программ и файлов в вашей системе. Она убирает подход по умолчанию, при котором любой файл может быть выполнен свободно. Вместо этого вы определяете политику (в формате XML-файла), в которой указывается, какие сертификаты или файлы являются доверенными. Затем система применяет эту политику, разрешая выполнение только утвержденных файлов и программ, блокируя все остальное.

Это сильно меняет ситуацию с безопасностью. Вместо того чтобы разрешать все по умолчанию, система теперь требует, чтобы программы и файлы доказывали свою надежность созданной вами политике перед выполнением.

**Управление приложениями работает по принципу принудительного доверия, а не обнаружения угроз.** Оно не делает различий между откровенно вредоносными программами и файлами, подписанными несколькими легитимными сертификатами: если файл явно не разрешен вашей локальной политикой, его выполнение блокируется. Этот проактивный подход особенно эффективен против уязвимостей нулевого дня, которые могут уклониться от традиционных антивирусов и других механизмов обнаружения. Ожидание реакции на новые угрозы может стоить слишком дорого.

Предотвращая выполнение любых неавторизованных файлов или программ, Управление приложениями мешает злоумышленникам и часто заставляет их отказаться от взлома. Например, даже если злоумышленнику удастся обмануть вас и заставить загрузить, казалось бы, легитимное ПО или файл, чтобы использовать уязвимости или заразить ваше устройство (например, с помощью социотехники, фишинга и других методов), ему будет отказано в выполнении, если он не соответствует политикам в вашей системе.

<br>

> [!TIP]\
> [Часто задаваемые вопросы по управлению приложениями (FAQ)](https://github.com/HotCakeX/Harden-Windows-Security/wiki/Application-Control-\(WDAC\)-Frequently-Asked-Questions-\(FAQs\))

<br>

## Каковы различные способы использования Управления приложениями в Windows?

Windows включает функцию под названием [Интеллектуальное управление приложениями](https://support.microsoft.com/en-us/topic/what-is-smart-app-control-285ea03d-fa88-4d56-882e-6698afdb7003). Оно действует как полностью автоматизированная система управления приложениями для вашего устройства. Будучи полностью автоматизированным, оно не настраивается вручную и не переопределяется. Интеллектуальное управление приложениями работает на основе [Microsoft Intelligent Security Graph](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/use-appcontrol-with-intelligent-security-graph#how-does-wdac-work-with-the-isg), который использует ИИ и передовые технологии для оценки безопасности выполнения файла или программы.

Для тех, кто ищет более детальный контроль, [**AppControl Manager**](https://github.com/HotCakeX/Harden-Windows-Security/wiki/AppControl-Manager) предлагает удобный графический интерфейс , в котором можно указать, какие файлы и программы разрешено запускать. Политики могут быть определены с использованием различных критериев в формате XML. Например, вы можете создать правила, чтобы блокировать выполнение всех файлов в определенной папке или разрешать только файлы, подписанные определенным сертификатом, эффективно блокируя неподписанные или по-другому подписанные файлы. AppControl Manager предоставляет полный набор инструментов для управления и настройки. Благодаря всем функциям, встроенным непосредственно в приложение, он устраняет необходимость переключения между различными инструментами или интерфейсами, делая процесс простым и эффективным.

Управление приложениями глубоко интегрировано в ядро Windows, и компонент, известный как Целостность кода, в основном отвечает за применение создаваемых нами политик. Он запускается очень рано во время загрузки системы, обеспечивая строгое соблюдение политик с самого начала.

<br>

## Концепции и ключевые слова Управления приложениями

### Базовая политика

Политики управления приложениями бывают разных типов, один из них — базовая политика. Базовая политика — это автономная политика, которая может быть развернута независимо. Она может содержать как разрешающие, так и запрещающие правила. Несколько базовых политик могут сосуществовать в одной системе.

<br>

### Дополнительная политика

Дополнительные политики зависят от базовых и не могут функционировать без них. Единственная цель дополнительной политики — добавить больше разрешающих правил в базовую политику, тем самым расширяя ее область действия.

<br>

### Политика маркировки AppID

Этот тип политики не разрешает и не блокирует никакие файлы. Вместо этого она программно помечает файлы и программы на основе определенных в ней правил. Другие программы могут затем обнаруживать эти метки и по-разному обрабатывать помеченные программы.

<br>

### Таблица: Типы политик и их функции

| Функции                                                             | Базовая политика | Дополнительная политика | Политика маркировки AppID           |
| ------------------------------------------------------------------- | ---------------- | ----------------------- | ----------------------------------- |
| Может быть автономной                                               | Да               | Нет                     | Да                                  |
| Может иметь запрещающие правила                                     | Да               | Нет                     | Нет                                 |
| Применяется к файлам пользовательского режима и режима ядра?        | Да               | Да                      | Нет - только пользовательский режим |
| Может быть подписана                                                | Да               | Да                      | Да                                  |
| Может ли подписанная версия быть удалена без доступа к сертификату? | Нет              | Да                      | Нет                                 |
| Может использоваться для аудита                                     | Да               | Нет                     | Нет                                 |

<br>

### Идентификатор политики

Каждый тип политики получает уникальный идентификатор в формате GUID. В одной системе не может существовать двух политик с одинаковым идентификатором. Попытка развернуть политику с повторяющимся идентификатором приведет к перезаписи существующей.

<br>

### Развертывание

Развертывание – это процесс установки политик в системе. Он включает в себя:

- Копирование политики в определенные системные расположения.

- Обновление репозитория политик системы для распознавания и применения новых политик.

<br>

### Режим аудита

Режим аудита — это функция, доступная для базовых политик. При развертывании в режиме аудита политика не блокирует никакие файлы. Вместо этого она записывает в журнал событий сведения о любых файлах, которые были бы заблокированы, если бы политика была развернута в принудительном режиме.

<br>

### Принудительный режим

Если политика не развернута в режиме аудита, она считается находящейся в принудительном режиме. В этом режиме:

- Политика разрешает только указанные файлы и программы.

- Все остальные файлы и программы блокируются.

<br>

## Руководства по управлению приложениями

- [How To Generate Audit Logs via App Control Policies](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-To-Generate-Audit-Logs-via-App-Control-Policies)

- [How To Create an App Control Supplemental Policy](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-To-Create-an-App-Control-Supplemental-Policy)

- [The Strength of Signed App Control Policies](https://github.com/HotCakeX/Harden-Windows-Security/wiki/The-Strength-of-Signed-App-Control-Policies)

- [How To Upload App Control Policies To Intune Using AppControl Manager](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-To-Upload-App-Control-Policies-To-Intune-Using-AppControl-Manager)

- [How To Create and Maintain Strict Kernel‐Mode App Control Policy](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-To-Create-and-Maintain-Strict-Kernel%E2%80%90Mode-App-Control-Policy)

- [How to Create an App Control Deny Policy](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-to-Create-an-App-Control-Deny-Policy)

- [Fast and Automatic Microsoft Recommended Driver Block Rules updates](https://github.com/HotCakeX/Harden-Windows-Security/wiki/Fast-and-Automatic-Microsoft-Recommended-Driver-Block-Rules-updates)

- [App Control Notes](https://github.com/HotCakeX/Harden-Windows-Security/wiki/WDAC-Notes)

- [How to use Windows Server to Create App Control Code Signing Certificate](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-to-Create-and-Deploy-a-Signed-WDAC-Policy-Windows-Defender-Application-Control)

- [App Control policy for BYOVD Kernel mode only protection](https://github.com/HotCakeX/Harden-Windows-Security/wiki/WDAC-policy-for-BYOVD-Kernel-mode-only-protection)

- [EKUs in App Control for Business Policies](https://github.com/HotCakeX/Harden-Windows-Security/wiki/EKUs-in-WDAC,-App-Control-for-Business,-Policies)

- [App Control Rule Levels Comparison and Guide](https://github.com/HotCakeX/Harden-Windows-Security/wiki/WDAC-Rule-Levels-Comparison-and-Guide)

- [Script Enforcement and PowerShell Constrained Language Mode in App Control Policies](https://github.com/HotCakeX/Harden-Windows-Security/wiki/Script-Enforcement-and-PowerShell-Constrained-Language-Mode-in-WDAC-App-Control-Policies)

- [How to Use Microsoft Defender for Endpoint Advanced Hunting With App Control](https://github.com/HotCakeX/Harden-Windows-Security/wiki/How-to-Use-Microsoft-Defender-for-Endpoint-Advanced-Hunting-With-WDAC-App-Control)

<br>

## Уровни использования Управления приложениями

Существует много способов использования функций управления приложениями, и здесь они отсортированы по уровню ограничений и защиты, которые они обеспечивают.

| Уровень защиты |                                                          Тип                                                         |                                                                                                                                                                                                                                                                                  Описание                                                                                                                                                                                                                                                                                 |
| :------------: | :------------------------------------------------------------------------------------------------------------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|        ⭐       |                                 Рекомендуемые Microsoft правила блокировки драйверов                                 |                                                            Список блокировки уязвимых драйверов включен по умолчанию для всех устройств, использующих HVCI или целостность памяти. [Встроенный список блокировок драйверов обновляется с каждым новым основным выпуском Windows, обычно 1-2 раза в год.](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/microsoft-recommended-driver-block-rules)                                                            |
|       ⭐⭐       |                        Быстрое обновление рекомендуемых Microsoft правил блокировки драйверов                        | Сам список блокировки драйверов [обновляется чаще](https://github.com/MicrosoftDocs/windows-itpro-docs/commits/public/windows/security/application-security/application-control/windows-defender-application-control/design/microsoft-recommended-driver-block-rules.md), чем два раза в год, [используйте AppControl Manager, чтобы настроить запланированную задачу, которая поддерживает список в актуальном состоянии.](https://github.com/HotCakeX/Harden-Windows-Security/wiki/Fast-and-Automatic-Microsoft-Recommended-Driver-Block-Rules-updates) |
|       ⭐⭐⭐      |                    Рекомендуемые Microsoft драйверы + правила блокировки пользовательского режима                    |                                                                                                                Используйте [AppControl Manager](https://github.com/HotCakeX/Harden-Windows-Security/wiki/AppControl-Manager), чтобы легко развернуть рекомендуемые Microsoft правила блокировки пользовательского режима в вашей системе в дополнение к правилам блокировки драйверов, которые применяются только к драйверам режима ядра.                                                                                                                |
|      ⭐⭐⭐⭐      |                   Правила блокировки + политика управления приложениями, настроенная с помощью ISG                   |                                                                                            В дополнение к правилам блокировки, разверните политику управления приложениями, использующую [ISG](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/use-appcontrol-with-intelligent-security-graph#how-does-wdac-work-with-the-isg) для автоматической авторизации на основе репутации.                                                                                            |
|      ⭐⭐⭐⭐⭐     |                                       Интеллектуальное управление приложениями                                       |            Это просто переключатель в разделе "Управление приложениями и браузером" Центра безопасности Windows. [Интеллектуальное управление приложениями](https://support.microsoft.com/en-us/topic/what-is-smart-app-control-285ea03d-fa88-4d56-882e-6698afdb7003) использует специальный вид политики, который обеспечивает большую защиту, чем предыдущий тип, благодаря тому, как он создан для обработки надежных приложений. Он использует оба рекомендуемых Microsoft правила блокировки по умолчанию.           |
|     ⭐⭐⭐⭐⭐⭐     |           Интеллектуальное управление приложениями + строгая политика управления приложениями в режиме ядра          |                                                                                                                            [Специальная строгая политика режима ядра](https://github.com/HotCakeX/Harden-Windows-Security/wiki/WDAC-policy-for-BYOVD-Kernel-mode-only-protection) дополняет интеллектуальное управление приложениями, обеспечивая строгие ограничения и контроль над всем, что хочет получить доступ к ядру ОС.                                                                                                                           |
|     ⭐⭐⭐⭐⭐⭐⭐    |                 Правила блокировки + политика разрешения Microsoft (неподписанная)                |                                                                                                                                                                     Правила блокировки всегда должны развертываться вместе с другими политиками управление приложениями. Политика разрешения Microsoft будет применять файлы как пользовательского, так и режима ядра.                                                                                                                                                                    |
|    ⭐⭐⭐⭐⭐⭐⭐⭐    |                  Правила блокировки + политика разрешения Microsoft (подписанная)                 |                                                                                                                                                                                             Подписание политики разрешения Microsoft вместе с правилами блокировки сделает их защищенными от несанкционированного доступа даже для системных администраторов.                                                                                                                                                                                             |
|    ⭐⭐⭐⭐⭐⭐⭐⭐⭐   |                     Правила блокировки + Windows по умолчанию (неподписанная)                     |                                                                                                                                                                                                                           Шаблон Windows по умолчанию предлагает больше контроля и ограничений, чем шаблон разрешения Microsoft.                                                                                                                                                                                                                          |
|   ⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐   |                      Правила блокировки + Windows по умолчанию (подписанная)                      |                                                                                                                                                                                             Подписание политики Windows по умолчанию вместе с правилами блокировки сделает их защищенными от несанкционированного доступа даже для системных администраторов.                                                                                                                                                                                             |
|   ⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐  | Правила блокировки + Windows по умолчанию + строгая политика режима ядра (все политики подписаны) |                                                                                                                                                                                                       Политика Windows по умолчанию + строгая политика режима ядра + правила блокировки, и все они подписаны, обеспечивают наивысший уровень защиты.                                                                                                                                                                                                      |

<br>

## Философия Управления приложениями

Традиционные парадигмы безопасности действуют реактивно, основываясь на идее обучения на ошибках — будь то взлом, поведение вредоносной программы или эксплойт. Антивирусные решения, EDR и даже продвинутые центры управления безопасностью, по своей сути, являются системами, которые требуют доказательств сбоя или вредоносной активности для развития своей защиты. Эта зависимость от обучения после инцидента создает опасный временной разрыв между обнаружением и смягчением, который злоумышленники используют. Но что, если вся парадигма обучения на ошибках устареет? Что, если сама необходимость в ошибках как катализаторах роста будет устранена?

Управление приложениями бросает вызов этой модели, предлагая проактивный, детерминированный подход к безопасности. Вместо того чтобы ждать, пока злоумышленник нарушит границу, оно действует по принципу упреждающего отказа. Обеспечивая соблюдение тщательно подобранной политики доверия, оно возвращает контроль защитнику. Ни один неавторизованный файл или программа, какими бы хитроумными они ни были, не могут быть выполнены без явного согласия. В этой модели защитник не просто учится на действиях злоумышленника; он сводит на нет необходимость учиться, лишая злоумышленника возможности действовать.

Этот подход выходит за рамки технической эффективности и затрагивает более широкий философский вопрос: должен ли рост и инновации всегда основываться на ошибках? В области кибербезопасности Управление приложениями предлагает альтернативный путь — будущее, в котором системы спроектированы так, чтобы предвидеть и предотвращать сами условия, приводящие к ошибкам. Оно воплощает философию, согласно которой профилактика не просто лучше лечения; это эволюция самого лечения.

Зачем ждать, пока ошибка сообщит вам о защите, если вы можете создать системы, которые проактивно поддерживают свою целостность? Зачем полагаться на инициативу злоумышленника, чтобы диктовать ваш ответ, если вы можете полностью вернуть инициативу себе? Что, если ошибка — это не вариант, и ее нельзя допускать ни при каких обстоятельствах?

<br>

## Документы Microsoft Learn, относящиеся к управлению приложениями

- [Application Control for Windows](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/appcontrol)
- [Understand App Control for Business policy design decisions](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/understand-appcontrol-policy-design-decisions)
- [Deploying App Control for Business policies](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/deployment/appcontrol-deployment-guide)
- [Use multiple App Control for Business Policies](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/deploy-multiple-appcontrol-policies)
- [Use audit events to create App Control policy rules](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/deployment/audit-appcontrol-policies)
- [Understand App Control for Business policy rules and file rules](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/select-types-of-rules-to-create#app-control-for-business-policy-rules)
- [Testing and Debugging AppId Tagging Policies](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/AppIdTagging/debugging-operational-guide-appid-tagging-policies)
- [App Control for Business example base policies](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/example-appcontrol-base-policies)
- [Configure the Application Identity service](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/applocker/configure-the-application-identity-service)
- [Microsoft recommended driver block rules](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/microsoft-recommended-driver-block-rules)
- [Microsoft recommended block rules](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/applications-that-can-bypass-appcontrol)
- [Create an App Control policy using a reference computer](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/create-appcontrol-policy-using-reference-computer)
- [Create an App Control policy for fully managed devices](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/create-appcontrol-policy-for-fully-managed-devices)
- [Create an App Control policy for lightly managed devices](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/create-appcontrol-policy-for-lightly-managed-devices)
- [Guidance on Creating App Control Deny Policies](https://learn.microsoft.com/en-us/windows/security/application-security/application-control/app-control-for-business/design/create-appcontrol-deny-policy)
- [Hypervisor-protected Code Integrity enablement](https://learn.microsoft.com/en-us/windows-hardware/design/device-experiences/oem-hvci-enablement)

<br>
