<template>
  <content-block class="box">
    <template #head> How to make ideal question </template>
    <template #body>
      <p>
        The community is here to help you with easy programming problems,
        algorithms, programming languages.<br /><br />
        Avoid posting questions that cannot be answered objectively.
      </p>
      <expander>
        <template #head>1. Describe the problem briefly</template>
        <template #body>
          <ul>
            <li>Include details about your goal</li>
            <li>Describe what you expected and what you got</li>
            <li>Добавьте сообщения об ошибках</li>
          </ul>
        </template>
      </expander>
            <expander>
        <template #head>2. Describe the problem briefly</template>
        <template #body>
          <ul>
            <li>Include details about your goal</li>
            <li>Describe what you expected and what you got</li>
            <li>Добавьте сообщения об ошибках</li>
          </ul>
        </template>
      </expander>
            <expander>
        <template #head>3. Describe the problem briefly</template>
        <template #body>
          <ul>
            <li>Include details about your goal</li>
            <li>Describe what you expected and what you got</li>
            <li>Добавьте сообщения об ошибках</li>
          </ul>
        </template>
      </expander>
    </template>
  </content-block>
</template>

<script>
import ContentBlock from "@/components/ContentBlock";
import Expander from "@/components/Expander";
export default {
  name: "HelpBox",
  components: {
    ContentBlock,
    Expander,
  },
};
</script>

<style scoped>
.box {
  margin-left: 10px;
}
</style>
