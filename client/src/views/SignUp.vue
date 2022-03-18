<template>
  <div class="page">
    <short-logo />
    <p class="page__slogan">Join the community.<br/> It's free and takes less than a minute.</p>
    <form-block class="page__form">
      <template #content>
        <div class="page__form-content">
          <q-input class="page__form-input">
            <template #label> Displayed name </template>
          </q-input>
          <q-input class="page__form-input">
            <template #label> Email </template>
          </q-input>
          <q-input class="page__form-input">
            <template #label> Password </template>
          </q-input>
        </div>
        <primary-button class="page__form-btn">
          <template #label>Sign Up</template>
        </primary-button>
      </template>
    </form-block>
    <div class="page__hint">
      <span class="page__hint-left">Have an account? </span>
      <router-link class="link" to="sign-in">Sign In</router-link>
    </div>
  </div>
</template>

<script>
import ShortLogo from "@/assets/short-logo";
import FormBlock from "@/components/FormBlock.vue";
import QInput from "@/components/QInput.vue";
import PrimaryButton from "@/components/PrimaryButton.vue";
export default {
  name: "SignUp",
  components: { ShortLogo, FormBlock, QInput, PrimaryButton },
};
</script>

<style scoped lang="scss">
.page {
  background-color: #0000;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  padding-top: 50px;
  &__form {
    margin-top: 2.5rem;
  }
  &__form-content {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  &__form-input {
    margin-bottom: 1rem;
    min-width: 250px;
  }
  &__form-btn {
    width: 100%;
    margin-top: 2.5rem;
  }
  &__hint {
    margin-top: 2.5rem;
    font-size: 12px;
  }
  &__hint-left {
    color: var(--black900);
  }
  &__slogan {
    font-size: 18px;
    color: var(--black900);
    text-align: center;
  }
}
</style>
