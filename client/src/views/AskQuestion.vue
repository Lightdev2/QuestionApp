<template>
  <div class="ask-page">
    <q-title class="ask-page__title"> Ask a public question </q-title>
    <div class="ask-page__body">
      <div class="ask-page__form">
        <editor />
      </div>
          <right-sidebar>
      <template #content> 
        <help-box/>  
      </template>
    </right-sidebar>
    </div>
  </div>
</template>

<script>
import QTitle from "../components/QTitle.vue";
import Editor from "../components/Editor.vue";
import RightSidebar from "../components/RightSidebar.vue";
import HelpBox from "../components/HelpBox.vue";
export default {
  components: { QTitle, Editor, RightSidebar, HelpBox },
  name: "AskQuestion",
};
</script>

<style scoped lang="scss">
.ask-page {
  &__title {
    height: 130px;
    display: flex;
    align-items: center;
    margin-left: 10px;
    padding-right: 10px;
    background-image: url(../assets/ask-background.svg);
    background-repeat: no-repeat;
    background-position: right bottom;
  }
  &__body {
    flex-grow: 1;
    display: flex;
  }
  &__form {
    border: 1px solid var(--black200);
    border-radius: 5px;
    background-color: var(--black50);
    width: 100%;
    padding: 10px;
    max-height: 400px;
    overflow: auto;
    height: 100%;
  }
}
</style>
